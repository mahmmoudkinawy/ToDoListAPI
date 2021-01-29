using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models;
using AutoMapper;
using ToDoList.DTOs;
using Microsoft.AspNetCore.Http;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDosController : ControllerBase
    {
        private readonly IToDoRepo _repository;
        private readonly IMapper _mapper;

        public ToDosController(IToDoRepo repository, IMapper mapper)
        {
            _repository = repository ??
                throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ToDoItem>> GetAll()
        {
            var toDoItemsFromRepo = _repository.GetAllItems();

            return Ok(toDoItemsFromRepo);
        }

        [HttpPost]
        public ActionResult CreateToDoItem
            (ToDoCreateDto toDoCreateDto)
        {
            var toDoItemToModel = _mapper.Map<ToDoItem>(toDoCreateDto);
            _repository.AddToDo(toDoItemToModel);
            _repository.SaveChanges();

            return Ok();
        }

        //Update to do text only 

        [HttpPost("{id}/change-text")]
        public ActionResult UpdateToDoItemText(Guid id,
            ToDoUpdateTextDto toDoUpdateTextDto)
        {
            var toDoItemFromRepo = _repository.GetToDoItemById(id);
            if (toDoItemFromRepo == null) return NotFound();

            toDoItemFromRepo.Text = toDoUpdateTextDto.Text;

            _repository.SaveChanges();

            return NoContent();
        }

        //Update to do complated only

        [HttpPost("{id}/complete")]
        public ActionResult UpdateToDoItemComplete(Guid id)
        {
            var toDoItemFromRepo = _repository.GetToDoItemById(id);
            if (toDoItemFromRepo == null) return NotFound();

            toDoItemFromRepo.Completed = true;

            _repository.SaveChanges();

            return NoContent();
        }
    }
}

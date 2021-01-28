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
    public class ToDoController : ControllerBase
    {
        private readonly IToDoRepo _repository;
        private readonly IMapper _mapper;

        public ToDoController(IToDoRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ToDoReadDto>> GetAll()
        {
            var toDoItemsFromRepo = _repository.GetAllItems();

            return Ok(_mapper.Map<IEnumerable<ToDoReadDto>>(toDoItemsFromRepo));
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
        
        [HttpPut("updateText/{id}")]
        public ActionResult UpdateToDoItemText(Guid id ,
            ToDoUpdateTextDto toDoUpdateTextDto)
        {
            var toDoItemFromRepo = _repository.GetToDoItemById(id);
            if (toDoItemFromRepo == null) return NotFound();

            _mapper.Map(toDoUpdateTextDto, toDoItemFromRepo);
            _repository.UpdateToDo(toDoItemFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //Update to do complated only

        [HttpPut("updateComplate/{id}")]
        public ActionResult UpdateToDoItemComplete(Guid id,
            ToDoUpdateCompleteDto toDoUpdateCompleteDto)
        {
            var toDoItemFromRepo = _repository.GetToDoItemById(id);
            if (toDoItemFromRepo == null) return NotFound();

            _mapper.Map(toDoUpdateCompleteDto, toDoItemFromRepo);
            _repository.UpdateToDo(toDoItemFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}

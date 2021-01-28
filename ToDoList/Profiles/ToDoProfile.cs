using AutoMapper;
using ToDoList.DTOs;
using ToDoList.Models;

namespace ToDoList.Profiles
{
    public class ToDoProfile : Profile
    {
        public ToDoProfile()
        {
            CreateMap<ToDoItem, ToDoReadDto>();
            CreateMap<ToDoCreateDto, ToDoItem>();

        }
    }
}

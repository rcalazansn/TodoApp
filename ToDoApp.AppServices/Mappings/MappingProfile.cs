using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.AppServices.Mappings
{
   public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<VM.TodoVM, Domain.Entities.Todo>().ReverseMap();
            CreateMap<VM.TodoFilterVM, Domain.Filters.TodoFilter>().ReverseMap();
        }
    }
}

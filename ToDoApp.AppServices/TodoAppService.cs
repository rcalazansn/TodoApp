using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.AppServices.VM;
using ToDoApp.DomainServices.Interfaces;
using ToDoApp.AppServices.Extensions;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Filters;

namespace ToDoApp.AppServices
{
    public class TodoAppService : Interfaces.ITodoAppService
    {
        private readonly ITodoDomainService Service;

        public TodoAppService(ITodoDomainService service)
        {
            this.Service = service;
        }

        public TodoVM Create(TodoVM todo)
        {
            var result = Service.Create(todo.MapTo<Todo>());

            return result.MapTo<TodoVM>();
        }

        public bool Delete(int id)
        {
            return Service.Delete(id);
        }

        public TodoVM GetById(int id)
        {
            return Service.GetById(id).MapTo<TodoVM>();
        }

        public IEnumerable<TodoVM> List(TodoFilterVM filter)
        {
            return Service.List(filter.MapTo<TodoFilter>()).EnumerableTo<TodoVM>();
        }

        public bool Update(TodoVM todo)
        {
            return Service.Update(todo.MapTo<Todo>()); 
        }
    }
}

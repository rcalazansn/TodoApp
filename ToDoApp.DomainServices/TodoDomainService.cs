﻿using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Filters;
using ToDoApp.Domain.Repositories;
using ToDoApp.DomainServices.Interfaces;

namespace ToDoApp.DomainServices
{
    internal class TodoDomainService : ITodoDomainService
    {
        private readonly ITodoRepository repository;

        public TodoDomainService(ITodoRepository repository)
        {
            this.repository = repository;
        }

        public Todo Create(Todo todo)
        {
            return repository.Create(todo);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id); 
        }

        public Todo GetById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Todo> List(TodoFilter filter)
        {
            return repository.List(filter);
        }

        public bool Update(Todo todo)
        {
            return repository.Update(todo); 
        }
    }
}

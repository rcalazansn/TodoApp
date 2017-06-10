using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Filters;
using Dapper;

namespace ToDoApp.Data.Repositories
{
    internal class TodoRepository : RepositoryBase, Domain.Repositories.ITodoRepository
    {
        public TodoRepository(IConfigurationRoot configuration) : base(configuration)
        {

        }

        public Todo Create(Todo todo)
        {
            todo.Id = connection.QueryFirst<int>("exec todo_sp_create @text, @isCompleted", todo);
            return todo;
        }

        public bool Delete(int id)
        {
            var affectRows = connection.Execute("exec todo_sp_delete @id", new { Id = id });
            return affectRows > 0;
        }

        public Todo GetById(int id)
        {
            var result = connection.QueryFirstOrDefault<Todo>("exec todo_sp_get @id", new { Id = id });
            return result;
        }

        public IEnumerable<Todo> List(TodoFilter filter)
        {
            var result = connection.Query<Todo>("exec todo_sp_list @id, @text, @isCompleted", filter);
            return result;
        }

        public bool Update(Todo todo)
        {
            var affectRows = connection.Execute("exec todo_sp_update @id, @text, @isCompleted", todo);
            return affectRows > 0;
        }
    }
}

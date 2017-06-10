using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.AppServices.VM;

namespace ToDoApp.AppServices.Interfaces
{
  public  interface ITodoAppService
    {
        TodoVM Create(TodoVM todo);

        IEnumerable<TodoVM> List(TodoFilterVM filter);

        TodoVM GetById(int id);

        bool Update(TodoVM todo);

        bool Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.AppServices.Interfaces;
using ToDoApp.AppServices.VM;

namespace ToDoApp.Controllers
{
    [Route("api/todo")]
    public class TodoController : Controller
    {
        private readonly ITodoAppService appService;

        public TodoController(ITodoAppService appService)
        {
            this.appService = appService;
        }

        [HttpGet]
        public IEnumerable<TodoVM> Get([FromQuery] TodoFilterVM filter)
        {
            return appService.List(filter);
        }

        [HttpGet("{id}")]
        public TodoVM GetById(int id)
        {
            return appService.GetById(id);
        }

        [HttpPost]
        public TodoVM Post([FromBody]TodoVM todo)
        {
            return appService.Create(todo);
        }

        [HttpPut("{id}")]
        public bool Put(int id, [FromBody]TodoVM todo)
        {
            return appService.Update(todo);
        }

        [HttpPut("{id}")]
        public bool Delete(int id)
        {
            return appService.Delete(id);
        }


    }
}
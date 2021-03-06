﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Data.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetType()
        {
            var dic = new Dictionary<Type, Type>();

            dic.Add(typeof(Domain.Repositories.ITodoRepository), typeof(Repositories.TodoRepository));

            return dic;
        }
    }
}

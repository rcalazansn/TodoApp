using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.AppServices.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetType()
        {
            var dic = new Dictionary<Type, Type>();

            dic.Add(typeof(Interfaces.ITodoAppService), typeof(TodoAppService));

            return dic;
        }
    }
}

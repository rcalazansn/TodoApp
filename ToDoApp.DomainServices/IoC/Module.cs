using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.DomainServices.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetType()
        {
            var dic = new Dictionary<Type, Type>();

            dic.Add(typeof(DomainServices.Interfaces.ITodoDomainService), typeof(DomainServices.TodoDomainService));

            return dic;
        }
    }
}

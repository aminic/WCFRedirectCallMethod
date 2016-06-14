using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class MyService : IMyService
    {
        public string Hello(string name)
        {
            return $"Hello {name}";
        }

        public string Welcome(string name)
        {
            return $"Welcome {name}";
        }
    }
}

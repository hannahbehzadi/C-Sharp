using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banana;

namespace HewwoWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hannah.hello();
            Console.ReadLine();
        }
    }
}

namespace Banana
{
    class Hannah
    {
        public static void hello()
        {
            Console.WriteLine("Hannah Banana");
        }
    }
}
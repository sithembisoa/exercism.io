using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class HelloWorld
    {
        public HelloWorld() { }

        public static String Hello(string name)
        {
            if (name == null) {
                return "Hello, World!";
            } else {
                return "Hello, " + name+"!";
            }
        }

        static void Main(string[] args) // static with a void (or int) return type
        {
        }
    }
}

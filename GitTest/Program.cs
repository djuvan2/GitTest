using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static int x = 1;   //master change1

        static void Main(string[] args)
        {
            Car car = new Car();
            x = 2;
        }
    }
    // Branch2 change1
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    class Progarm
    {
        static void Main(string[] args)
        {
            TempConverter tempConverter = new TempConverter();
            tempConverter.Start();
            Console.ReadKey();
        }
    }
}

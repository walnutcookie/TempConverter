using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    /// <summary>
    ///  Check user input
    /// </summary>
    public class Input
    {
        public static int ReadIntConsole(string DisplayMsg)
        {
            // reads from console until a correct int is provided
            bool goodNumber = false;
            int convertedValue = 0;

            do
            {
                Console.Write(DisplayMsg);

                goodNumber = int.TryParse(Console.ReadLine(), out convertedValue);

                if (!goodNumber)
                {
                    Console.Write("Invalid input. Please enter the correct number.\n");
                }
            } while (!goodNumber);

            return convertedValue;
        }
    }
}

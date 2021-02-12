using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    class TempConverter
    {
        public void Start()
        {
            int userInput = 0;

            do
            {
                /// <summary
                DisplayMenu();

                // read uerinput
                userInput = Input.ReadIntConsole("Your choice: ");
                // check userinput
                switch(userInput)
                {
                    case 1:
                        CalculateFahrenheitToCelsius();
                        break;

                    case 2:
                        CaltulateCelsiusToFahrenheit();
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please enter a valid number.");
                        break;

                }
            } while (userInput != 0);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("\n ******* Temperature converter menu *******");
            Console.Out.WriteLine("  1 Convert °F to °C");
            Console.Out.WriteLine("  2 Convert °C to °F");
            Console.Out.WriteLine("  0 Exit");
            Console.Out.WriteLine(" *******************************************");
        }

        public void CalculateFahrenheitToCelsius()
        {
            float convertedValue = 0;
        }

        public void CaltulateCelsiusToFahrenheit()
        {

        }
    }
}

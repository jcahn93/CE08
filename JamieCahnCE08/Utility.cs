using System;
using System.Collections.Generic;
using System.Text;

namespace JamieCahnCE08
{
    class Utility
    {
        public static void PauseBeforeContinuing()
        {
            Console.WriteLine("Press a key to continue.");
            Console.ReadKey();
        }

        public static void Incorrect(string thingy)
        {
            Console.WriteLine("Invalid data. " + thingy + " needs to exist.");
            PauseBeforeContinuing();

        }

        public static void Invalid()
        {
            Console.WriteLine("Invalid Input, Please Try Again.");
        }


    }
}

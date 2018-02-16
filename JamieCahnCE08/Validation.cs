using System;
using System.Collections.Generic;
using System.Text;

namespace JamieCahnCE08
{
    class Validation
    {
        public static int GetInt(string message = "Enter an integer: ")
        {
            int validatedInt;
            string input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            while (Int32.TryParse(input, out validatedInt) == false);

            return validatedInt;
        }

        public static int GetInputInt(string message = "")
        {
            int validatedInt;
            string input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            while (Int32.TryParse(input, out validatedInt) == false);

            return validatedInt;
        }

        public static int GetInt(int min, int max, string message = "Enter an integer: ")
        {
            int validatedInt = 0;
            string input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while ((Int32.TryParse(input, out validatedInt) &&
                        validatedInt > min && validatedInt <= max) == false);

            return validatedInt;
        }

        public static int CheckGrade(int min, int max, string message = "")
        {
            int validatedInt = 0;
            string input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            while ((Int32.TryParse(input, out validatedInt) &&
                        validatedInt > min && validatedInt <= max) == false);
            return validatedInt;
        }

        public static decimal CardValue(decimal min, decimal max, string message = "")
        {
            decimal validatedDec = 0;
            string input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            while ((Decimal.TryParse(input, out validatedDec) &&
                            validatedDec > min && validatedDec <= max) == false);
            return validatedDec;
        }



        public static float GetMileage(float min, float max, string message = "")
        {
            float validatedFloat = 0;
            string input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            while ((float.TryParse(input, out validatedFloat) &&
                        validatedFloat > min && validatedFloat <= max) == false);
            return validatedFloat;
        }

        public static bool GetBool(string message)
        {
            bool retValue = false;
            bool keepChecking = true;
            string input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "true":
                    case "t":
                    case "yes":
                    case "y":
                        {
                            retValue = true;
                            keepChecking = false;
                        }
                        break;
                    case "false":
                    case "f":
                    case "no":
                    case "n":
                        {
                            keepChecking = false;
                        }
                        break;

                }

            } while (keepChecking);

            return retValue;
        }

        public static Double GetDouble(int min, int max, string message = "Enter an integer: ")
        {
            double validatedDouble = 0;
            string input;

            do
            {
                Console.Write("Enter an integer: ");
                input = Console.ReadLine();
            } while ((Double.TryParse(input, out validatedDouble) &&
                        validatedDouble > min && validatedDouble <= max) == false);

            return validatedDouble;
        }

    }
}

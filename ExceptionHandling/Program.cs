using System.Diagnostics.Metrics;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicExceptionHandling();
            MultipleExceptionTypes();
            FinalyBlockUsage();
            CustomExceptionClass();
            ExceptionPropagation();
            UsingThrowAndCatch();
        }

        static void BasicExceptionHandling()
        {
            Console.WriteLine("------------------ 1 -----------------------");

            Console.Write("Enter a number: ");
            // TODO:
            // Convert the input to an integer using int.Parse().
            // Use a try-catch block to handle FormatException if the user enters a non-numeric value.
            // Display an error message in case of an exception.
            // Output the input if correct
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Your number entered is: "+ number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine("------------------- 2 ----------------------");

        }

        static void MultipleExceptionTypes()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Include a catch block for OverflowException to handle cases where the number is too large or small for an int.
            // Display appropriate error messages for different exceptions.
       
            try
            {
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine(number1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch(OverflowException)
            {
                Console.WriteLine("the number is too large or small for an int");
            }

            Console.WriteLine("------------------ 3 -----------------------");

        }

        static void FinalyBlockUsage()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Add a finally block to the program.
            // Use the finally block to display a message whether an exception was caught or not.
            try
            {
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine(number1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("the number is too large or small for an int");
            }
            finally
            {
                Console.WriteLine("this message is displayed whether an exception was caught or not");
            }
            Console.WriteLine("------------------- 4 ----------------------");

        }

        // Class for custom exception type
        class NegativeNumberException : ApplicationException
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        static void CustomExceptionClass()
        {
            Console.Write("Enter a positive number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Modify your number input program to throw NegativeNumberException if the user enters a negative number.
            // Handle this exception in a separate catch block and display an appropriate message.
           
            try
            {
                int number2 = int.Parse(Console.ReadLine());

                if (number2 < 0)
                {
                    throw new NegativeNumberException("enter a positive not negative number");
                }
                Console.WriteLine("thanks, you entered number: " + number2);
            }
            catch (NegativeNumberException)
            {
                Console.WriteLine("enter a positive not negative number");
            }
            Console.WriteLine("------------------- 5 ----------------------");

        }

        static void ExceptionPropagation()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumber that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // In this function, call CheckNumber inside a try block and handle the exception.
            static void CheckNumber(int number3)
            {
                if (number3 > 100)
                {
                    throw new ArgumentOutOfRangeException("this number is greater than 100, please try again");
                }
            }

            try
            {
                int number = int.Parse(Console.ReadLine());
                CheckNumber(number);
                Console.WriteLine("You entered: " + number);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error Please enter a number less than 100 ");     
            }     

            

            Console.WriteLine("------------------- 6 ----------------------");
        }

        // NOTE: You can implement the CheckNumber here

        static void UsingThrowAndCatch()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumberWithLogging that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // Modify the CheckNumberWithLogging function to log the exception message before throwing it.
            // In this function, catch the exception in the main program and display the logged message.
            {
                static void CheckNumberWithLogging(int number6)
                {
                    if (number6 > 100)
                    {
                        throw new ArgumentOutOfRangeException(nameof(number6), "Number should not be greater than 100.");
                    }
                }
                try
                {
                    int number6 = int.Parse(Console.ReadLine());
                    CheckNumberWithLogging(number6);
                    Console.WriteLine("You entered: " + number6);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Logged Error. Number shouldnt be more than a 100");
                }
            }

            
        

        Console.WriteLine("------------------- Thanks ----------------------");

        }

        // NOTE: You can implement the CheckNumberWithLogging here
    }
}
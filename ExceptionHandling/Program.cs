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
            Console.Write("Enter a number: ");
            try
            {
                // Convert the input to an integer using int.Parse().
                int number = int.Parse(Console.ReadLine());
                // Output the input if correct
                Console.WriteLine("Entered number: " + number);
            }
            catch (FormatException)
            {
                // Handle FormatException if the user enters a non-numeric value.
                Console.WriteLine("Error: Please enter a valid number.");
            }
        }

        static void MultipleExceptionTypes()
        {
            Console.Write("Enter a number: ");
            try
            {
                // Convert the input to an integer using int.Parse().
                int number = int.Parse(Console.ReadLine());
                // Output the input if correct
                Console.WriteLine("Entered number: " + number);
            }
            catch (FormatException)
            {
                // Handle FormatException if the user enters a non-numeric value.
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (OverflowException)
            {
                // Handle OverflowException if the number is too large or small for an int.
                Console.WriteLine("Error: The entered number is too large or too small.");
            }
        }

        static void FinalyBlockUsage()
        {
            Console.Write("Enter a number: ");
            try
            {
                // Convert the input to an integer using int.Parse().
                int number = int.Parse(Console.ReadLine());
                // Output the input if correct
                Console.WriteLine("Entered number: " + number);
            }
            catch (FormatException)
            {
                // Handle FormatException if the user enters a non-numeric value.
                Console.WriteLine("Error: Please enter a valid number.");
            }
            finally
            {
                // Display a message whether an exception was caught or not.
                Console.WriteLine("Finally block executed.");
            }
        }

        // Class for custom exception type
        class NegativeNumberException : ApplicationException
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        static void CustomExceptionClass()
        {
            Console.Write("Enter a number: ");
            try
            {
                // Convert the input to an integer using int.Parse().
                int number = int.Parse(Console.ReadLine());

                // Throw NegativeNumberException if the user enters a negative number.
                if (number < 0)
                {
                    throw new NegativeNumberException("Error: Negative numbers are not allowed.");
                }

                // Output the input if correct
                Console.WriteLine("Entered number: " + number);
            }
            catch (FormatException)
            {
                // Handle FormatException if the user enters a non-numeric value.
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (NegativeNumberException ex)
            {
                // Handle NegativeNumberException and display an appropriate message.
                Console.WriteLine(ex.Message);
            }
        }

        static void ExceptionPropagation()
        {
            Console.Write("Enter a number: ");
            try
            {
                // Write a function CheckNumber that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
                int number = int.Parse(Console.ReadLine());
                CheckNumber(number);
                // Output the input if correct
                Console.WriteLine("Entered number: " + number);
            }
            catch (FormatException)
            {
                // Handle FormatException if the user enters a non-numeric value.
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle ArgumentOutOfRangeException and display an appropriate message.
                Console.WriteLine(ex.Message);
            }
        }

        // Function to check if the number is greater than 100
        static void CheckNumber(int number)
        {
            if (number > 100)
            {
                throw new ArgumentOutOfRangeException("Error: Number cannot be greater than 100.");
            }
        }

        static void UsingThrowAndCatch()
        {
            Console.Write("Enter a number: ");
            try
            {
                // Write a function CheckNumberWithLogging that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
                int number = int.Parse(Console.ReadLine());
                CheckNumberWithLogging(number);
                // Output the input if correct
                Console.WriteLine("Entered number: " + number);
            }
            catch (FormatException)
            {
                // Handle FormatException if the user enters a non-numeric value.
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Catch the exception and display the logged message.
                Console.WriteLine("Logged Exception: " + ex.Message);
            }
        }

        // Function to check if the number is greater than 100 and log the exception message
        static void CheckNumberWithLogging(int number)
        {
            if (number > 100)
            {
                Console.WriteLine("Logging Exception: Number cannot be greater than 100.");
                throw new ArgumentOutOfRangeException("Error: Number cannot be greater than 100.");
            }
        }
    }
}

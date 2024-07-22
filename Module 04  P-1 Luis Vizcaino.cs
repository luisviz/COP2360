{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("Enter the first number:");
            string input1 = Console.Readline();

            Console.Writeline("Enter the second number:");
            string input2 = Console.Readline();

            try
            {
                int number1 = Convert.ToInt32(input1);
                int number2 = Convert.ToInt32(input2);

                int result = Divide(number1, number2)
                Console.Writeline($"The result of {number1} divided by {number 2} is: {result}");
            }
            catch (FormatException ex)
            {
                Console.Writeline("Error: One or both of the inputs are not valid integers");
                Console.Writeline($"Detailed error message: {ex.Message}");
                
                throw;
            }
            catch (DivideByZeroException ex)
            {
                Console.Writeline("Error: Division by zero is not allowed.");
                Console.Writeline($"Detailed error message : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.Writeline("An unexpected error occured.");
                Console.Writeline($"Detailed error message: {ex.Message}");
            }
        
            Console.WriteLine("Press any key to exit...");
            Console.Readkey();
        }   

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
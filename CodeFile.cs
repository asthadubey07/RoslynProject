 namespace RoslynProject
{
    public class MathOperations
    {
        private readonly int _factor; // Avoids CS8618 (Non-nullable field is uninitialized)

        public MathOperations(int factor)
        {
            if (factor == 0)
            {
                throw new ArgumentException("Factor cannot be zero.", nameof(factor));
            }

            _factor = factor; // Ensures the field is properly initialized
        }

        public int Multiply(int number)
        {
            return number * _factor; // Safe operation, avoids null issues
        }

        public void DisplayResult(int number)
        {
            int result = Multiply(number);
            Console.WriteLine($"Multiplication result: {result}"); // Ensures no unused variables
        }
    }
}

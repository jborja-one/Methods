namespace Methods {
    public class Program {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();

            // Split the input and convert to an array of integers
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            int sumResult = Add(numbers);
            Console.WriteLine("Sum: " + sumResult);

            int diffResult = Subtract(numbers);
            Console.WriteLine("Difference: " + diffResult);

            int productResult = Multiply(numbers);
            Console.WriteLine("Product: " + productResult);

            int divisionResult = Divide(numbers);
            Console.WriteLine("Division: " + divisionResult);
        }

        static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static int Subtract(params int[] numbers)
        {
            int diff = 0;
            foreach (int number in numbers)
            {
                diff -= number;
            }
            return diff;
        }

        static int Multiply(params int[] numbers)
        {
            int product = 0;
            foreach (int number in numbers)
            {
                product *= number;
            }
            return product;
        }

        static int Divide(params int[] numbers)
        {
            int divisionResult = 0;
            foreach (int number in numbers)
            {
                divisionResult /= number;
            }
            return divisionResult;
        }
    }
}

//I would appreciate some advise on my mulpitly and divide methods. I think I have the right idea, the problem is that the initial value cannot be 0.

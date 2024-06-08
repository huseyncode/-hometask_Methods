class Program
{
    static void Main(string[] args)
    {
        Methods methods = new Methods();

        int product = methods.Multiply(5, 4);
        Console.WriteLine($"Product: {product}");

        int square = methods.Square(5);
        Console.WriteLine($"Square: {square}");

        int[] arr = { 1, 2, 3, 4, 5 };
        int sum = methods.SumArray(arr);
        Console.WriteLine($"Sum: {sum}");

        string message = methods.WelcomeMessage("Huseyn", "Sukurov");
        Console.WriteLine(message);

        string reversed = methods.ReverseString("Salam");
        Console.WriteLine($"Reversed: {reversed}");

        int result = methods.CheckDivisibleBySeven(49);
        Console.WriteLine($"Result: {result}");

        double rectanglePerimeter = methods.Perimeter(5.0, 4.0);
        Console.WriteLine($"Rectangle Perimeter: {rectanglePerimeter}");

        double trianglePerimeter = methods.Perimeter(3.0, 4.0, 5.0);
        Console.WriteLine($"Triangle Perimeter: {trianglePerimeter}");

        int spaces = methods.CountSpaces("Salam Eleykum");
        Console.WriteLine($"Spaces: {spaces}");
    }
}
public class Methods
{
    // Task 1
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    // Task 2
    public int Square(int a)
    {
        return a * a;
    }

    // Task 3
    public int SumArray(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }

    // Task 4
    public string WelcomeMessage(string name, string surname)
    {
        return $"Xoş gəlmisiniz, {name} {surname}!";
    }

    // Task 5
    public string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Task 6
    public int CheckDivisibleBySeven(int num)
    {
        if (num % 7 == 0)
        {
            Console.WriteLine("7-ə bölünür");
            return num;
        }
        else
        {
            int lower = num - (num % 7);
            int upper = lower + 7;
            return (num - lower < upper - num) ? lower : upper;
        }
    }

    // Task 7
    public double Perimeter(double side1, double side2) // For rectangle
    {
        return 2 * (side1 + side2);
    }

    public double Perimeter(double side1, double side2, double side3) // For triangle
    {
        return side1 + side2 + side3;
    }

    // Task 8
    public int CountSpaces(string sentence)
    {
        int count = 0;
        foreach (char c in sentence)
        {
            if (c == ' ')
            {
                count++;
            }
        }
        return count;
    }
}
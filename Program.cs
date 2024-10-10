using System;
using Week2Day2HW;

// Run the array reversal example
int[] numbers = GenerateNumbers();  // Step 1: Generate an array
Reverse(numbers);                   // Step 2: Reverse the array
PrintNumbers(numbers);              // Step 3: Print the reversed array

Console.WriteLine();

// Print the first 10 Fibonacci numbers
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
}

Console.WriteLine();

// Create some colors
Color redColor = new Color(255, 0, 0);
Color greenColor = new Color(0, 255, 0);

// Create balls with different colors and sizes
Ball ball1 = new Ball(10, redColor);
Ball ball2 = new Ball(15, greenColor);

// Throw the balls a few times
ball1.Throw();
ball1.Throw();
ball2.Throw();

// Pop the first ball
ball1.Pop();

// Try to throw the popped ball
ball1.Throw(); // This should not increment the throw count

// Display throw counts
Console.WriteLine("Ball 1 throw count: " + ball1.GetThrowCount()); // Should be 2
Console.WriteLine("Ball 2 throw count: " + ball2.GetThrowCount()); // Should be 1

// Test the grayscale calculation
Console.WriteLine("Ball 1 color grayscale: " + ball1.BallColor.GetGrayscale());
Console.WriteLine("Ball 2 color grayscale: " + ball2.BallColor.GetGrayscale());

// Method to generate an array of numbers
static int[] GenerateNumbers(int length = 10)  // Default length is 10
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = i + 1;  // Fill with 1 to 10
    }
    return array;
}

// Method to reverse the contents of an array
static void Reverse(int[] array)
{
    int start = 0;
    int end = array.Length - 1;
    while (start < end)
    {
        int temp = array[start];
        array[start] = array[end];
        array[end] = temp;
        start++;
        end--;
    }
}

// Method to print the contents of an array
static void PrintNumbers(int[] array)
{
    foreach (int number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

// Method to calculate the nth Fibonacci number using recursion
static int Fibonacci(int n)
{
    if (n <= 2)
        return 1; // Base case: the first and second numbers are both 1
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive case
}


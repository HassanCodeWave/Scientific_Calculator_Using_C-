using System;

bool continueCalculating = true;

while (continueCalculating)
{
    Console.WriteLine("Choose calculator type:");
    Console.WriteLine("1. Normal Calculator");
    Console.WriteLine("2. Scientific Calculator");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        double num1, num2, result;
        Console.WriteLine("Normal Calculator");
        Console.Write("Enter first number: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");

        Console.Write("Enter your choice: ");
        int operation = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero!");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                break;
            default:
                Console.WriteLine("Invalid operation. Please try again.");
                break;
        }
    }
    else if (choice == 2)
    {
        double num, result;
        Console.WriteLine("Scientific Calculator");
        Console.Write("Enter number: ");
        num = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Exponentiation (^)");
        Console.WriteLine("2. Square root");
        Console.WriteLine("3. Logarithm (base 10)");
        Console.WriteLine("4. Sine");
        Console.WriteLine("5. Cosine");
        Console.WriteLine("6. Tangent");

        Console.Write("Enter your choice: ");
        int operation = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case 1:
                double exponent;
                Console.Write("Enter exponent: ");
                exponent = double.Parse(Console.ReadLine());
                result = Math.Pow(num, exponent);
                Console.WriteLine("Result: " + result);
                break;
            case 2:
                if (num < 0)
                {
                    Console.WriteLine("Error: Square root of a negative number!");
                }
                else
                {
                    result = Math.Sqrt(num);
                    Console.WriteLine("Result: " + result);
                }
                break;
            case 3:
                if (num <= 0)
                {
                    Console.WriteLine("Error: Logarithm of a non-positive number!");
                }
                else
                {
                    result = Math.Log10(num);
                    Console.WriteLine("Result: " + result);
                }
                break;
            case 4:
                result = Math.Sin(num);
                Console.WriteLine("Result: " + result);
                break;
            case 5:
                result = Math.Cos(num);
                Console.WriteLine("Result: " + result);
                break;
            case 6:
                result = Math.Tan(num);
                Console.WriteLine("Result: " + result);
                break;
            default:
                Console.WriteLine("Invalid operation. Please try again.");
                break;
        }
    }
    else if (choice == 3)
    {
        continueCalculating = false;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}

// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
while (true)
{
    Console.WriteLine("Calculator");
    Console.WriteLine("First Number: ");
    var str1 = Console.ReadLine();
    Console.WriteLine("Second Number: ");
    var str2 = Console.ReadLine();

    if (int.TryParse(str1, out _) && int.TryParse(str2, out _))
    {
        var num1 = Convert.ToInt32(str1);
        var num2 = Convert.ToInt32(str2);
        Console.WriteLine("Choose Operation: Add, Subtract, Multiplication, Division, Remainder, Exponent, Clear");
        var action = Console.ReadLine();
        
        if(action == "Add" || action == "Subtract" || action == "Multiplication" || action == "Division" || action == "Remainder" || action == "Exponent" || action == "Clear")
        {
            switch (action)
            {
                case "Add":
                    Console.WriteLine(num1 + num2);
                    break;
                case "Subtract":
                    Console.WriteLine(num1 - num2);
                    break;
                case "Multiplication":
                    Console.WriteLine(num1 * num2);
                    break;
                case "Division":
                    if (num1 != 0 || num2 != 0)
                        Console.WriteLine(num1 / num2);
                    else
                        Console.WriteLine("Division cannot take place with a zero.");
                    break;
                case "Remainder":
                    if (num1 > num2)
                        Console.WriteLine(num1 % num2);
                    else Console.WriteLine("Can't Implement");
                    break;
                case "Exponent":
                    var result = 1;
                    for (int i = 0; i < num2; i++)
                    {
                        result = result * num1;
                    }
                    Console.WriteLine(result);
                    break;
                case "Clear":
                    break;
            }
        }
        else
        {
            Console.WriteLine("Operation Not Part of possible operations");
        }
    }
    else
    {
        Console.WriteLine("One of the inputs is not a Number.");
    }
}







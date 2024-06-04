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
        Console.WriteLine("Choose Operation: Add, Subtract,\n Multiplication, Division,\n Remainder, Power,\n Exponent, Square,\n Sq.Root, Sin, ASin,\n Cos, ACos,\n Tan, ATan,\n Clear");
        var action = Console.ReadLine();
        
        if(action == "Add" || action == "Subtract" || action == "Multiplication" || action == "Division" || action == "Remainder" || action == "Power" || action == "Exponent" || action == "Square" || action == "Sq.Root" || action == "Sin" || action == "ASin" || action == "Cos" || action == "ACos" || action == "Tan" || action == "ATan" || action == "Clear")
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
                    if (num2 != 0)
                        Console.WriteLine(num1 / num2);
                    else
                        Console.WriteLine("Division cannot take place with a zero.");
                    break;
                case "Remainder":
                    if (num1 > num2)
                        Console.WriteLine(num1 % num2);
                    else Console.WriteLine("Can't Implement");
                    break;
                case "Power":
                    var result = 1;
                    for (int i = 0; i < num2; i++)
                    {
                        result = result * num1;
                    }
                    Console.WriteLine(result);
                    break;
                case "Exponent":
                    Console.WriteLine("The Exponent of {0} is {1}", num1, Math.Exp(num1));
                    Console.WriteLine("The Exponent of {0} is {1}", num2, Math.Exp(num2));
                    break;
                case "Square":
                    Console.WriteLine("The Square of {0} is {1}", num1, num1*num1);
                    Console.WriteLine("The Square of {0} is {1}", num2, num2*num2);
                    break;
                case "Sq.Root":
                    Console.WriteLine("The Square Root of {0} is {1}", num1, Math.Sqrt(num1));
                    Console.WriteLine("The Square Root of {0} is {1}", num2, Math.Sqrt(num2));
                    break;
                case "Sin":
                    Console.WriteLine("Num1 or Num2 for the Sin:");
                    var choose = Console.ReadLine();
                    if (choose == "Num1")
                        Console.WriteLine("The Sin of {0} is {1}", num1, Math.Sin(num1));
                    if (choose == "Num2")
                        Console.WriteLine("The Sin of {0} is {1}", num2, Math.Sin(num2));
                    else Console.WriteLine("Pick Either Num1 or Num2");
                    break;
                case "ASin":
                    Console.WriteLine("Num1 or Num2 for the Sin:");
                    choose = Console.ReadLine();
                    if (choose == "Num1")
                        Console.WriteLine("The ASin of {0} is {1}", num1, Math.Asin(num1));
                    if (choose == "Num2")
                        Console.WriteLine("The ASin of {0} is {1}", num2, Math.Asin(num2));
                    else Console.WriteLine("Pick Either Num1 or Num2");
                    break;
                case "Cos":
                    Console.WriteLine("Num1 or Num2 for the Sin:");
                    choose = Console.ReadLine();
                    if (choose == "Num1")
                        Console.WriteLine("The Cos of {0} is {1}", num1, Math.Cos(num1));
                    if (choose == "Num2")
                        Console.WriteLine("The Cos of {0} is {1}", num2, Math.Cos(num2));
                    else Console.WriteLine("Pick Either Num1 or Num2");
                    break;
                case "ACos":
                    Console.WriteLine("Num1 or Num2 for the Sin:");
                    choose = Console.ReadLine();
                    if (choose == "Num1")
                        Console.WriteLine("The ACos of {0} is {1}", num1, Math.Acos(num1));
                    if (choose == "Num2")
                        Console.WriteLine("The ACos of {0} is {1}", num2, Math.Acos(num2));
                    else Console.WriteLine("Pick Either Num1 or Num2");
                    break;
                case "Tan":
                    Console.WriteLine("Num1 or Num2 for the Sin:");
                    choose = Console.ReadLine();
                    if (choose == "Num1")
                        Console.WriteLine("The Tan of {0} is {1}", num1, Math.Tan(num1));
                    if (choose == "Num2")
                        Console.WriteLine("The Tan of {0} is {1}", num2, Math.Tan(num2));
                    else Console.WriteLine("Pick Either Num1 or Num2");
                    break;
                case "ATan":
                    Console.WriteLine("Num1 or Num2 for the Sin:");
                    choose = Console.ReadLine();
                    if (choose == "Num1")
                        Console.WriteLine("The ATan of {0} is {1}", num1, Math.Atan(num1));
                    if (choose == "Num2")
                        Console.WriteLine("The ATan of {0} is {1}", num2, Math.Atan(num2));
                    else Console.WriteLine("Pick Either Num1 or Num2");
                    break;
                case "Clear":
                    break;
            }
        }
        else
            Console.WriteLine("Operation Not Part of possible operations");
    }
    else
        Console.WriteLine("One of the inputs is not a Number.");
}







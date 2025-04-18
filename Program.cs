// See https://aka.ms/new-console-template for more information
using System;
class Act1
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Hi! welcome to the C# Calculator or Dice or Guess the Number program!");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("\nPlease enter your name:");
        string studentName = Console.ReadLine();

        sayHi(studentName);

        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Dice");
        Console.WriteLine("3. Guess the Number");

        Console.WriteLine("-----------------------------------------");

        var option = Console.ReadLine();
        switch (option)
        {
            case "1":
                Calculator();
                break;
            case "2":
                Dice();
                break;
            case "3":
                Guess();
                break;
            default:
                Console.WriteLine("Invalid option. Please enter 1, 2, or 3.");
                break;
        }

        static void Calculator()
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("C# Calculator program!");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Choose the Operation you want to perform:");

            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.WriteLine("-----------------------------------------");
            var operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("The result is: " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("The result is: " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("The result is: " + result);
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("\nThe result is: " + result);
                    }
                    else
                    {
                        Console.WriteLine("\nError: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid operation. Please enter +, -, *, or /.");
                    break;
            }
            Console.ReadKey();
        }

        static void Dice()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("C# Dice program!");
            Console.WriteLine("-----------------------------------------");
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("You rolled a " + diceRoll + "!");
            Console.ReadKey();
        }
        static void Guess()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("C# Guess the Number!");
            Console.WriteLine("-----------------------------------------");

            Random rand = new Random();
            int ranNum = rand.Next(1, 101);
            int guess = 0;
            int attempts = 0;
            Console.WriteLine("Guess a number between 1 and 100:");

            while (guess != ranNum)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess < ranNum)
                    {
                        Console.WriteLine("Your guess is too low! Try again");
                    }
                    else
                    {
                    Console.WriteLine("Your guess is too high! Try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Your guess must be a number");
                    attempts--;
                }
                attempts++;
            }
                Console.WriteLine("Congratulations! You guessed the number " + ranNum + " in " + attempts + " attempts.");
                Console.ReadLine();
        }
        static void sayHi(string name)
        {
            Console.WriteLine("\nHi " + name + "!");
        }
    }
}

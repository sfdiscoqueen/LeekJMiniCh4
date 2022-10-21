// Jasmine Leek
// 20 oct 2022
// Mini-Challenge #4 "Greater Than or Less Than"
// This is a program that asks a user to enter two numbers, then compares each number 
// as greater than, less than, or equal to the other


Console.Clear();
string userChoice = "";

int num1, num2, result;
bool validNum1, validNum2;


Console.WriteLine("Let's compare numbers!");
do
{

    do
    {
        Console.Write("Please enter a number: ");
        validNum1 = Int32.TryParse(Console.ReadLine(), out num1);
        if (validNum1 == false)
        {
            Console.WriteLine("Whoops! Invalid entry! ");
        }
    } while (validNum1 == false);


    do
    {
        Console.Write("Please enter another number: ");
        validNum1 = Int32.TryParse(Console.ReadLine(), out num2);
        if (validNum1 == false)
        {
            Console.WriteLine("Whoops! Invalid entry! ");
        }
    } while (validNum1 == false);


    if (num1 > num2)
    {
        Console.WriteLine($"{num1} is greater than {num2}");

        Console.WriteLine($"{num2} is less than {num1}");

    }
    if (num1 < num2)
    {
        Console.WriteLine($"{num1} is less than {num2}");

        Console.WriteLine($"{num2} is greater than {num1}");

    }
    if (num1 == num2)
    {
        Console.WriteLine($"{num1} is equal to {num2}");
    }

    do
    {
        Console.WriteLine("Do you want to play again? Type 'yes' to play again or 'no' to quit: ");
        userChoice = Console.ReadLine().ToUpper();
        if (userChoice != "YES" && userChoice != "NO")
        {
            Console.WriteLine("Invalid response. Please type 'yes' or 'no' silly!");
        }
    } while (userChoice != "YES" && userChoice != "NO");
} while (userChoice == "YES");

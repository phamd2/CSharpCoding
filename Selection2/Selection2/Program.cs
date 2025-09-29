// Question 1

Console.WriteLine("Enter a number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a number:");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("They are equal");
}
else
{
    Console.WriteLine("They are not equal");
}


// Question 2

Console.WriteLine("Enter a number:");
int oddoreven = int.Parse(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.Write("This number is even");
}
else {
    Console.Write("This number is odd");
}

// Question 3
Console.WriteLine("Enter a number:");
int leapYear = int.Parse(Console.ReadLine());

if (num1 % 4 == 0)
{
    Console.WriteLine(num1 + " is a leap year");
}
else
{
    Console.WriteLine(num1 + " is not a leap year");
}


// Question 4
Console.WriteLine("Enter a number:");
int value = int.Parse(Console.ReadLine());

if (value % 3 == 0 && value % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (value % 3 == 0 && value % 5 != 0)
{
    Console.WriteLine("Fizz");
}
else if (value % 5 == 0 && value % 3 != 0) 
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(value);
}


// Question 5
static void FindFactors()
{
    Console.WriteLine("Enter a number:");
    int num = int.Parse(Console.ReadLine());
    int numFactors = 0;
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            numFactors++;
        }
    }
    Console.WriteLine(numFactors);
}


// Question 6

static void vowelChecker(string letter)
{
    switch (letter.ToLower())
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine("True");
            break;
        default:
            Console.WriteLine("False");
            break;

    }
}


// Question 7

static void blocksNeeded(int fileSize)
{
    const int kibibyte = 1024;
    const int blockSize = 512;
    int newFileSize = kibibyte * fileSize;
    int numblocks = (int)Math.Ceiling((double)newFileSize / blockSize);
    Console.WriteLine(numblocks);
}


// Question 8
// Accidentally did compound interest



static void pocketMoney(double allowance, double percentage)
{
    double percentageDecimal = (1 + (percentage / 100));
    double percentagechange = Math.Pow(percentageDecimal, 52);
    double amountSavedWeek = allowance * percentageDecimal;
    double amountSavedYear = allowance * percentagechange;

    Console.WriteLine($"In a week you will have saved {amountSavedWeek:F2}");
    Console.WriteLine($"In a year you will have saved {amountSavedYear:F2}");

}


// Question 9

static void GreatestValueFinder()
{
    Console.WriteLine("Enter your first number");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your second number");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your third number");
    int num3 = int.Parse(Console.ReadLine());

    int higherValue = Math.Max(num1, num2);                    // W3 Schools
    int result = Math.Max(higherValue, num3);

    Console.WriteLine($"The greatest value is {result}");
}


GreatestValueFinder(value1, value2, value3);



//Question 10
static void DetermineQuadrant();
{
    Console.WriteLine("Input coordinates in (x,y)");
    string inputCoordinates = Console.ReadLine();
    inputCoordinates = inputCoordinates.Trim('(', ')'); // Taken off chatgpt. Takes off the brackets from the input, splits the values by the comma and assigns the value into their respective variables
    string[] parts = inputCoordinates.Split(',');
    int x = int.Parse(parts[0]);
    int y = int.Parse(parts[1]);

    if (x > 0 && y > 0)
    {
        Console.WriteLine("The coordinate lies in Quadrant 1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("The coordinate lies in Quadrant 2");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("The coordinate lies in Quadrant 4");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("The coordinate lies in Quadrant 3");
    }
    else if (x == 0 || y == 0) ;
    {
        Console.WriteLine("The coordinate lies on an axis");
    }
    
}
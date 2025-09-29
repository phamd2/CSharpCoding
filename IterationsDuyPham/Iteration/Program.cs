// Question 1

void Countdown(int n)
{
    for (int i = n; i > 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Blast Off!");

}


// Question 2

void triStar(int a)
{
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", i)));
    }
}


// Question 3

void gridMaker(int numRow, int numCol)
{
    string row = "+ - - -";
    string col = "|      ";
        for (int r = 0; r < numRow; r++)
        {
 
            Console.WriteLine(string.Concat(Enumerable.Repeat(row, numCol)) + "+");


            Console.WriteLine(string.Concat(Enumerable.Repeat(col, numCol)) + "|");
        }


        Console.WriteLine(string.Concat(Enumerable.Repeat(row, numCol)) + "+");
    }


// Question 4

void gridMaker2(int numRow, int numCol)
{
    string row = "-------";
    string col = "|      ";
        for (int r = 0; r < numRow; r++)
        {
 
            Console.WriteLine(string.Concat(Enumerable.Repeat(row, numCol)));


            Console.WriteLine(string.Concat(Enumerable.Repeat(col, numCol)) + "|");
        }


        Console.WriteLine(string.Concat(Enumerable.Repeat(row, numCol)));
    }

// Question 5

static void Menu()
{
    Console.WriteLine("Question Menu");
    Console.WriteLine("Enter question number or 0 to exit");
    Console.WriteLine("Choice:");

    string choice = Console.ReadLine();

    if (int.TryParse(choice, out int input))
    {
        if (input == 0)
        {
            Console.WriteLine("Exiting");

        }
        else if (input == 1)
        {
            int variable = 5;

            Countdown(variable);
        }
        else if (input == 2)
        {
            Console.WriteLine("Input number of rows");
            string parameter = Console.ReadLine();
            Int32.TryParse(parameter, out int starrows);
            triStar(starrows);
        }
        else if (input == 3)
        {
            Console.WriteLine("Input number of rows");
            string numRows = Console.ReadLine();
            Int32.TryParse(numRows, out int numRow);

            Console.WriteLine("Input number of column");
            string numCols = Console.ReadLine();
            Int32.TryParse(numCols, out int numCol);

            gridMaker(numRow, numCol);
        }
        else if (input == 4)
        {
            Console.WriteLine("Input number of rows");
            string numRows = Console.ReadLine();
            Int32.TryParse(numRows, out int numRow);

            Console.WriteLine("Input number of column");
            string numCols = Console.ReadLine();
            Int32.TryParse(numCols, out int numCol);

            gridMaker2(numRow, numCol);
        }
    }
}

// Question 6

void Ask(int n)
{
    double total = 0;
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"Enter number {i}: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            total += number;
        }
        else
            Console.WriteLine("Enter a valid integer");

    }
    double mean = total / n;
    Console.WriteLine($"The total is {total}");
    Console.WriteLine($"The mean is {mean}");
    
}


// Question 7

bool IsPrime(int n)
{
    if (n <= 1)
        return false;
    if (n == 2)
        return true;

    int numfactors = 0;

    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
            numfactors++;
    }
    return numfactors == 2;
}



bool isPerfect(int n)
{
    if (n <= 1)
        return false;
    int total = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
            total += i;
    }
    return total == n;
}

bool isAbundant(int n)
{
    if (n <= 1)
        return false;

    int sum = 0;
        for (int i = 1; i < n; i++) 
        {
            if (n % i == 0)
                sum += i;
        }

        return sum > n;
}


// Question 8

void checkISBN()
{
    int total = 0;
    Console.WriteLine("Write an ISBN with a missing digit");
    string ISBN = Console.ReadLine();

    if (ISBN.Length != 10)
    {
        Console.WriteLine("ISBN must be 10 digits");

    }

    int hiddenindex = 0;
    for (int i = 0; i < 10; i++)
    {
        if (ISBN[i] == '?')
            hiddenindex = i;
        else
        {
            Int32.TryParse(ISBN[i].ToString(), out int number);
            total += number * (10 - i);

        }
    }
    for (int possible = 0; possible <= 9; possible++)
    {
        int NewTotal = total + possible * (10 - hiddenindex);

        if (NewTotal % 11 == 0)
        {
            Console.WriteLine($"The missing digit is: {possible}");
        }
    }

}
checkISBN();



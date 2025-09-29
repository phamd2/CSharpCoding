// Question 1

int integerSum(int a, int b)
{
    return a + b;
}

double integerSum(double a, double b)
{
    return a + b;
}

decimal integerSum(decimal a, decimal b)
{
    return a + b;
}

// Question 2

int digitsSum(int number)
{
int sum = 0;
        string digits = number.ToString();

        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i] - '0';
        }

        return sum;
}
Console.Write(digitsSum(17));


// Question 3


bool checkPrime(int a)
{
    int numFactors = 0;
    for (int i = 1; i <= a; i++)
    {
        if (a % i == 0)
            numFactors++;

    }
    if (numFactors == 2)
        return true;
    else
        return false;
}


// Question 4

int numSpaces(string text)
{
    int count = 0;
    string letter;
    for (int i = 0; i < text.Length; i++)
    {
        letter = text.Substring(i, 1);
        if (letter == " ")
        {
            count++;
        }

    }
    return count;
}



// Question 5

void Swap(ref int i1, ref int i2)
{
    int r = i1;
    i1 = i2;
    i2 = r;
}

// Question 6

string Translate(int a, int b)
{

    if (b == 2)
        return "0b" + Convert.ToString(a, 2);
    else if (b == 16)
        return "0x" + Convert.ToString(a, 16).ToUpper();
    else
        return ("Only hex or binary, base 2 or base 16");
}

// Question 7
// I'm not too sure what the question was asking so I don't know if I did it right

static int Multiply(int multiplicand = 12, int multiplier = 2)
{
    return multiplicand * multiplier;
}





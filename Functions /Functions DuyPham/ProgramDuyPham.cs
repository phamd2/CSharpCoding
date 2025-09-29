// Question 1
/*
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
*/
// Question 2

int digitsSum(int a)
{
    int total = 0;
    int lengthDigits = a.ToString.Length();

    for (int i = lengthDigits; i <= lengthDigits+1; i++)
    {
        int total = total + a[i];

    }
    return total;
}

digitsSum(17);
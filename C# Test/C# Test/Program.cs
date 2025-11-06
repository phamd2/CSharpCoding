using System.Diagnostics;
using System.Linq.Expressions;
using System.Xml;

/* Fix me */
List<string> listOfStrings = new List<string> { "13", "Candy", "Mike Myers", "True", "#FF5F1F", "1978" };

/*
Debug.Assert(NextOnAThursday() == 2031);

int NextOnAThursday()
{
    int day = 0;
    int year = 2025;
    while (day != 4)
    {
        for (int i=2025; i<=5000; i++)
        {
            int today = (int)(new DateTime(i, 11, 6).DayOfWeek);
            if (today == 4)
            {
                year++;
                day += 4;
                return year;
            }
            else if (today != 4)
            {
                year++;
            }
            
        }
    }
    throw new NotImplementedException();


}

Console.WriteLine(NextOnAThursday());




List<int> pileSizes = new List<int> { 4, 9, 11, 17 };
int numHours = 8;


int EatingSweets(List<int> pileSizes, int numHours)
{

    for (int sph = 1; sph <= 7; sph++)
    {
        for (int i = 0; i <= 4; i++)
        {

            while (numHours != 0)
            {
                int total = 0;
                total = pileSizes[i] - sph;
                numHours -= 1;
            }

        }
    }

}
Debug.Assert(EatingSweets(pileSizes, numHours) == 6);


Debug.Assert(CuttingChocolate(5) == 6);
Debug.Assert(CuttingChocolate(6) == 9);
Debug.Assert(CuttingChocolate(7) == 12);
Debug.Assert(CuttingChocolate(8) == 16);
*/



// Note the exclamation marks showing not, so False 
Debug.Assert(!ValidatePassword("ABCdef")); // too short
Debug.Assert(!ValidatePassword("ABCABC12!")); // duplicates, doesn't divide by 11
Debug.Assert(!ValidatePassword("ABCabcde!")); // no digit 
Debug.Assert(!ValidatePassword("ABCdef12!")); // doesn't divide by 11 
Debug.Assert(ValidatePassword("ABCdef12&")); // should succeed 


bool ValidatePassword(string candidate)
{
    if (candidate.Length < 8)
    {
        return false;
    }
    else if (candidate.Length > 32)
        return false;
    else
    {
        string letter = candidate.Substring(0, 1);
        if (letter )
    }


        return false;
}

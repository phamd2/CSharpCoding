using System.Diagnostics;

// Question 1a

static int SumOfList(List<int> ListOfIntegers)
{
    int total = 0;
    int lengthlist = ListOfIntegers.Count;

    for (int i = 0; i < lengthlist; i++)
    {
        total += ListOfIntegers[i];
    }

    Console.WriteLine($"The sum of the digits is: {total}");
    return total;
}

List<int> ListOfInts= new List<int>() { 3, 2, 1, 5, 6, 67, -5 };
int sum = SumOfList(ListOfInts);
Debug.Assert(sum == 79, "Broken");
Console.WriteLine("Code works");

// Question 1b

void MaxList(List<int> Listintegers)
{
    int largest = 0;
    foreach (int i in Listintegers)
        if (i > largest)
        {
            largest = i;
        }
    Console.WriteLine(largest);
    
    
}

//Question 1c

int MinList(List<int> Listintegers)
{
    int smallest = Listintegers[0];
    foreach (int i in Listintegers)
        if (i < smallest)
        {
            smallest = i;
        }
    return smallest;

}
int min = MinList(ListOfInts);
Debug.Assert(min == -5, "Broken");
Console.WriteLine("Code works");

// Questino 1d

List<int> checkNegative(List<int> Listintegers)
{
    List<int> negativenums = new List<int>();
    foreach (int i in Listintegers)
    {
        if (i < 0)
        {
            negativenums.Add(i);
        }
    }
    return negativenums;
}
List<int> negativenumberslist= new List<int>() { -74, -8, -1, 5, 6, 67, -5 };
List<int> negative = checkNegative(negativenumberslist);
Debug.Assert(
            negative.Count == 4 &&
            negative[0] == -74 &&
            negative[1] == -8 &&
            negative[2] == -1 &&
            negative[3] == -5,
            "Broken");
Console.WriteLine("Code works");

// Question 2

static string PrintList(List<int> listofnum)
{
    string output = "[";

    for (int i = 0; i < listofnum.Count; i++)
    {
        output += listofnum[i];

        if (i < listofnum.Count - 1)
        {
            output += ", ";
        }
    }
    output += "]";
    Console.WriteLine(output);
    return output;
}

List<int> ListOfInts2 = new List<int>() { 3, 2, 1, 5, 6, 67, -5 };

string printedList = PrintList(ListOfInts);

Debug.Assert(printedList == "[3, 2, 1, 5, 6, 67, -5]", "Broken");

Console.WriteLine("Code works");

// Question 3

bool AreListsEqual(List<int> list1, List<int> list2)
{
    if (list1.Count != list2.Count)
        return false;

    for (int i = 0; i < list1.Count; i++)
    {
        if (list1[i] != list2[i])
            return false;
    }
    return true;
}

List<int> a = new List<int> { 1, 2, 3 };
List<int> b = new List<int> { 1, 2, 3 };
List<int> c = new List<int> { 1, 2, 4 };

Debug.Assert(AreListsEqual(a, b), "Should return true");
Console.WriteLine("Code works");
Debug.Assert(!AreListsEqual(a, c), "should return true");
Console.WriteLine("Code works");

// Question 4

bool SameItems(List<int> list1, List<int> list2)
{
    HashSet<int> nodupes1 = new HashSet<int>(list1); // Taken off stack overflow
    HashSet<int> nodupes2 = new HashSet<int>(list2);

    return nodupes1.SetEquals(nodupes2); // Taken off Microsoft Learn/Ignite
}

List<int> list1 = new List<int> { 2, 2, 3, 4, 5, 6, 7, 7, 7 };
List<int> list2 = new List<int> { 2, 3, 4, 5, 6, 7 };
List<int> list3 = new List<int> { 2, 2, 3, 4, 5, 6, 7, 7, 7, 8 };

Debug.Assert(SameItems(list1, list2), "Should return True");
Console.WriteLine("Code works");
Debug.Assert(SameItems(list3, list2) == false, "Should return False");
Console.WriteLine("Code works");


// Question 5a
bool naivesearch(List<int> list, int value)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] == value)
            return true;
    }
    return false;
}

// Question 5b
bool binarysearch(List<int> list, int value)
{
    int leftside = 0;
    int rightside = list.Count - 1;

    while (leftside <= rightside)
    {
        int midvalue = (leftside + (rightside - leftside)) / 2;

        if (list[midvalue] == value)
            return true;
        else if (list[midvalue] < value)
            leftside = midvalue + 1;
        else
            rightside = midvalue - 1;
    }
    return false;
}

List<int> sortedList = new List<int> { 1, 3, 5, 7, 9, 11, 13 };

Debug.Assert(naivesearch(sortedList, 5) == true, "Should return true");
Debug.Assert(naivesearch(sortedList, 13) == true, "Should return true");
Debug.Assert(naivesearch(sortedList, 0) == false, "Should return false");

Debug.Assert(binarysearch(sortedList, 5) == true, "Should return true");
Debug.Assert(binarysearch(sortedList, 6) == false, "Should return false");
Debug.Assert(binarysearch(sortedList, 1) == true, "Should return true");


// Question 6
List<int> checkDuplicates(List<int> list)
{
    List<int> checkedvalues = new List<int>();
    List<int> duplicates = new List<int>();

    foreach (int num in list)
    {
        if (checkedvalues.Contains(num))
        {
            if (!duplicates.Contains(num))
                duplicates.Add(num);
        }
        else
        {
            checkedvalues.Add(num);
        }
    }
    return duplicates;
}


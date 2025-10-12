using System.Diagnostics;
using System.IO.Enumeration;
using System.Text;

// Question 1
void storetxtfile(string inputfile)
{
    StringBuilder sb = new StringBuilder();
    Console.WriteLine("Enter your sentence");
    string userinput = " ";
    while (userinput != "")
    {
        userinput = Console.ReadLine();
        sb.AppendLine(userinput);
    }
    if (!File.Exists(inputfile))
        File.WriteAllText("sentences.txt", sb.ToString());
    else if (File.Exists(inputfile))
        File.AppendAllText(inputfile, sb.ToString());

}

// Question 2
List <string> findStation()
{
    List<string> output = new List<string>();
    foreach (string line in File.ReadAllLines("stations.txt"))
    {
        if (line.ToLowerInvariant().Contains("station"))
            output.Add(line);
    }

    return output;
}

Console.WriteLine(findStation());

// Question 3
List<string> noMackeral()
{
    string fileName = "stations.txt";
    HashSet<char> notused = new HashSet<char>("mackerel");
    List<string> output = new List<string>();

    foreach (string line in File.ReadAllLines(fileName))
    {
        string stationname = line.Split(',')[0].Trim().ToLowerInvariant();
        bool containsletters = false;
        foreach (char c in stationname)
        {
            if (notused.Contains(c))
            {
                containsletters = true;
                break;
            }
        }
        if (!containsletters)
            output.Add(line);
    }

    return output;
}
void printmackeral()
{
    List<string> results = noMackeral();
    foreach (string station in results)
        Console.WriteLine(station);
}

printmackeral();


List<string> resultsM = noMackeral();
Debug.Assert(resultsM[0] == "St. John's Wood, Jubilee", "Broken");
Console.WriteLine("Working");

// Question 3b
List<string> noPiranha()
{
    string fileName = "stations.txt";
    HashSet<char> notused = new HashSet<char>("piranha");
    List<string> output = new List<string>();

    foreach (string line in File.ReadAllLines(fileName))
    {
        string stationname = line.Split(',')[0].Trim().ToLowerInvariant();
        bool containsletters = false;
        foreach (char c in stationname)
        {
            if (notused.Contains(c))
            {
                containsletters = true;
                break;
            }
        }
        if (!containsletters)
            output.Add(line);
    }

    return output;
}

void printpiranha()
{
    List<string> results = noPiranha();
    foreach (string station in results)
        Console.WriteLine(station);
}

printpiranha();
List<string> resultsP = noPiranha();
Debug.Assert(resultsP[0] == "Stockwell, Victoria, Northern", "Broken");
Console.WriteLine("Working");



// Question 3c
List<string> noSturgeon()
{
    string fileName = "stations.txt";
    HashSet<char> notused = new HashSet<char>("sturgeon");
    List<string> output = new List<string>();

    foreach (string line in File.ReadAllLines(fileName))
    {
        string stationname = line.Split(',')[0].Trim().ToLowerInvariant();
        bool containsletters = false;
        foreach (char c in stationname)
        {
            if (notused.Contains(c))
            {
                containsletters = true;
                break;
            }
        }
        if (!containsletters)
            output.Add(line);
    }

    return output;
}

void printSturgeon()
{
    List<string> results = noSturgeon();
    foreach (string station in results)
        Console.WriteLine(station);
}

printSturgeon();
List<string> resultsS = noSturgeon();
Debug.Assert(resultsS[0] == "Balham, Northern" && resultsS[1] == "Blackwall, Docklands Light Railway", "Broken");
Console.WriteLine("Working");

// Question 3d

List<string> noBacteria()
{
    string fileName = "stations.txt";
    HashSet<char> notused = new HashSet<char>("bacteria");
    List<string> output = new List<string>();

    foreach (string line in File.ReadAllLines(fileName))
    {
        string stationname = line.Split(',')[0].Trim().ToLowerInvariant();
        bool containsletters = false;
        foreach (char c in stationname)
        {
            if (notused.Contains(c))
            {
                containsletters = true;
                break;
            }
        }
        if (!containsletters)
            output.Add(line);
    }

    return output;
}

void printBacteria()
{
    List<string> results = noBacteria();
    if (results.Count() == 0)
        Console.WriteLine("No stations found");
    foreach (string station in results)
            Console.WriteLine(station);
}

printBacteria();
List<string> resultsB = noBacteria();
Debug.Assert(resultsB[0] == "No stations found", "Broken");
Console.WriteLine("Working");



// Question 4

List<string> sameletters()
{
    string filename = "stations.txt";
    List<string> output = new List<string>();
    foreach (string line in File.ReadAllLines(filename))
    {
        string stationName = line.Split(',')[0].Trim();
        string[] words = stationName.Split(' ');
        List<string> seperatewords = new List<string>();
        foreach (string word in words)
        {
            if (!string.IsNullOrWhiteSpace(word))
                seperatewords.Add(word);
        }


        if (seperatewords.Count == 2)
        {
            char firstletter = char.ToLower(seperatewords[0][0]);
            char secondletter = char.ToLower(seperatewords[1][0]);

            if (firstletter == secondletter)
                output.Add(stationName);
        }
    }

    return output;

}

void printsameletters()
{
    List<string> results = sameletters();
    if (results.Count() == 0)
        Console.WriteLine("No stations found");
    else
    {
        foreach (string station in results)
            Console.WriteLine(station);
    }
}
printsameletters();

List<string> resultsSameLetters = sameletters();
Debug.Assert(resultsSameLetters[0] == "Charing Cross" && resultsSameLetters[1] == "Clapham Common" && resultsSameLetters[2] == "Golders Green" && resultsSameLetters[3] == "Seven Sisters" && resultsSameLetters[4] == "Sloane Square", "Broken");
Console.WriteLine("Code works");


// Question 5

string mostStations()
{
    string filename = "stations.txt";
    Dictionary<string, int> stationcount = new Dictionary<string, int>(); //GeeksforGeeks

    foreach (string line in File.ReadAllLines(filename))
    {
        string[] parts = line.Split(',');

        for (int i = 1; i < parts.Length; i++)
        {
            string linename = parts[i].Trim();

            if (stationcount.ContainsKey(linename))
            {
                stationcount[linename]++;
            }
            else
            {
                stationcount[linename] = 1;
            }
        }
    }

    string maxline = "";
    int highestnum = 0;

    foreach (string linename in stationcount.Keys)
    {
        int count = stationcount[linename];
        if (count > highestnum)
        {
            highestnum = count;
            maxline = linename;
        }
    }

    return maxline;

}

Console.WriteLine(mostStations());

Debug.Assert(mostStations() == "District", "Should be district line");
Console.WriteLine("Code works");
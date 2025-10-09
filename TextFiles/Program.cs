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
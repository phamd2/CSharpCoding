void compressed()
{
    Console.WriteLine("Enter your string");
    string original = Console.ReadLine();
    char current = 'A';
    int total = 0;
    foreach (char c in original)
    {
        if (c == current)
            total++;
        else
        {
            Console.Write(Convert.ToString(current) + total+ ' ');
            current = c;
            total = 1;
        }

    }
    Console.Write(Convert.ToString(current) + total + ' ');
}
compressed();
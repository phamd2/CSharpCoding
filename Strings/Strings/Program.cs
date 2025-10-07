using System.Diagnostics;

string mexicanwave(string str)
{
    var result = new List<string>();

    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsWhiteSpace(str[i]))
            continue;

        char[] chars = str.ToCharArray();
        chars[i] = char.ToUpper(chars[i]);
        result.Add(new string(chars));
    }

    return string.Join(", ", result);
}


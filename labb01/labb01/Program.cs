void labb01(string inputString)
{

    // Ny hashset för utskriva substrings
    HashSet<string> printedSubstrings = new HashSet<string>();

    // För varje index i inputstring
    for (int i = 0; i < inputString.Length; i++)
    {
        // Kolla om indexet är en siffra 
        if (Char.IsDigit(inputString[i]))
        {
            for (int j = i + 1; j < inputString.Length; j++)
            {
                if (inputString[i] == inputString[j])
                {
                    string substring = inputString.Substring(i, j - i + 1);

                    bool innehållerBokstav = false;

                    foreach (char c in substring)
                    {
                        if (!Char.IsDigit(c))
                        {
                            innehållerBokstav = true;
                            break;
                        }
                    }

                    if (!innehållerBokstav && !printedSubstrings.Contains(substring))
                    {
                        printedSubstrings.Add(substring);

                        writeColored(inputString, substring);
                        break;
                    }
                }
            }
        }
    }
}

void writeColored(string theFullString, string theSubstring)
{
    int index = theFullString.IndexOf(theSubstring);

    if (index >= 0)
    {
        Console.Write(theFullString.Substring(0, index));

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(theFullString.Substring(index, theSubstring.Length));

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(theFullString.Substring(index + theSubstring.Length));
    }
}

labb01("511586162272249122u727264482");
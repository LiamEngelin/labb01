void labb01()
{
    Console.WriteLine("Mata in en sträng");
    string inputString = Console.ReadLine();
    Console.WriteLine();
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
    long summa = 0;
    foreach (string s in printedSubstrings)
    {
        summa += Convert.ToInt64(s);
    }
    Console.WriteLine();
    Console.WriteLine($"Summan av delsträngarna är {summa}");
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

labb01();

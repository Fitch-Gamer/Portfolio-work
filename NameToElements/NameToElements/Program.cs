using System.Runtime.CompilerServices;

Main();
Console.ReadKey();
void Main()
{
    string[] RawElements = File.ReadAllLines("PeriodicElements.txt");
    string[] ElementSymbols = new string[RawElements.Length];
    int i = 0;
    int LastElement = 118;
    foreach (string s in RawElements)
    {
        ElementSymbols[i] = s.Substring(0,2).Trim();
        i++;
    }
    Console.WriteLine("Please enter a name");
    string Name = Console.ReadLine();
    Letter[] NameLetters = new Letter[Name.Length];
    i = 0;
    foreach (char c in Name)
    {
        NameLetters[i] = new Letter( c,' ');
        if(i!=0)
        {
            NameLetters[i-1].NextChar= c;
        }
        i++;
    }
    i = 0;
    foreach (Letter l in NameLetters)
    {
        if (l.ThisChar != ' ')
        {
            bool found = false;
            string CombChar = l.ThisChar.ToString() + l.NextChar.ToString();
            int ii = 0;
            foreach (string s in ElementSymbols)
            {
                if (s.ToLower() == CombChar && ElementSymbols[LastElement] != s)
                {
                    NameLetters[i + 1].ThisChar = ' ';
                    found = true;
                    Console.WriteLine(RawElements[ii]);
                    LastElement = ii;
                }
                ii++;

            }
            if (!found)
            {
                ii = 0;

                foreach (string s in ElementSymbols)
                {
                    if (s.ToLower() == l.ThisChar.ToString().ToLower() && ElementSymbols[LastElement] != s)
                    {
                        found = true;
                        Console.WriteLine(RawElements[ii]);
                        LastElement = ii;
                    }
                    ii++;

                }
                if(!found)
                {
                    Console.WriteLine(l.ThisChar.ToString());
                }

            }
            
        }
        i++;
    }
}

public class Letter
{
    public char ThisChar;
    public char NextChar;

    public Letter (char thischar, char nextchar)
    {
        ThisChar = thischar;
        NextChar = nextchar;
    }
}

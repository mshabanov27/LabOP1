using System;

namespace Lab5
{
    class Lab5
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                int dflt = 0;
                for (int j = i; j != 0; j = j/10)
                {
                    dflt = dflt + j % 10;
                }
                if (dflt >= 10)
                {
                    int dflt2 = 0;
                    for (int f = dflt; f != 0; f = f / 10)
                    {
                        dflt2 = dflt2 + f % 10;
                    }
                    if (dflt2 >= 10)
                    {
                        int dflt3 = 0;
                        for (int k = dflt2; k != 0; k = k/10)
                        {
                            dflt3 = dflt3 + k % 10;
                        }
                        if (i % dflt3 == 0)
                        {
                            Console.WriteLine(i + " is " + dflt3);
                        }
                    }
                    else
                    {
                        if (i % dflt2 == 0)
                        {
                            Console.WriteLine(i + " is " + dflt2);
                        }
                    }
                }
                else
                {
                    if (i % dflt == 0)
                    {
                        Console.WriteLine(i + " is " + dflt);
                    }
                }
                }
            }
        }
    }

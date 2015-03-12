using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vstup = new List<int>();
            int znak = Console.Read();
            bool konec = false;
            bool minus = false;
            int hodnota = 0;
            int j = 0;
            while ((znak != (10)) & (konec == false))
            {
                while (znak == 45) 
                {
                    znak = Console.Read();
                    if ((znak < 58) & (znak > 47))
                    { minus = true; }
                    else
                    {
                        if (j > 1)
                        {
                            hodnota = vstup[j - 2] - vstup[j - 1];
                            vstup[j - 2] = hodnota;
                            vstup.RemoveAt(j - 1);
                            j = j - 1;
                        }
                        else { Console.Write("Chyba!"); konec = true; }
                    }
                }
                if ((znak < 58) & (znak > 47))
                {
                    int cislo = znak-48;
                    znak = Console.Read();
                    while ((znak < 58) & (znak > 47))
                    { 
                        cislo = cislo * 10 + znak - 48;
                        znak = Console.Read();
                    }
                    if (minus) cislo=-cislo;
                    vstup.Add(cislo);
                    j = j + 1;
                }                
                switch (znak)
                    {
                        case 42: if (j > 1) 
                        {
                            hodnota = vstup[j-1] * vstup[j - 2];
                            vstup[j - 2] = hodnota;
                            vstup.RemoveAt(j-1);
                            j = j - 1;}
                        else {Console.Write("Chyba!");
                        konec = true;
                        }
                            break;
                        case 43: if (j > 1)
                        {
                            hodnota = vstup[j-1] + vstup[j - 2];                
                            vstup[j - 2] = hodnota;
                            vstup.RemoveAt(j - 1);
                            j = j - 1;}
                            else { Console.Write("Chyba!"); konec = true; }
                            break;
                        case 47: if (j > 1)
                        {
                            hodnota = vstup[j-2] / vstup[j-1];
                            vstup[j - 2] = hodnota;
                            vstup.RemoveAt(j - 1);
                            j = j - 1;}
                            else { Console.Write("Chyba!"); konec = true; }
                            break;
                    }           
                              
                znak = Console.Read();
                minus = false;
            }
            if (j > 0) { Console.Write(vstup[0]); };
            //Console.Write(vstup[0]);
           // Console.ReadLine();
            //Console.ReadLine();
        }
    }
}

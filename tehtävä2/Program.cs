using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = null;
            double doublerino;
            int integer;
            {
                // kysytään käyttäjältä rivi
                StreamWriter outputFile = new StreamWriter(@"Z:\olio ohjelmointi\Demo07\tehtävä2.integer.txt");
                StreamWriter outputFile2 = new StreamWriter(@"Z:\olio ohjelmointi\Demo07\tehtävä2.txt");
                do
                {

                    Console.WriteLine("Give a number (enter stops):");
                    number = Console.ReadLine();


                    bool parsed = int.TryParse(number, out integer);
                    if (!parsed)
                    {
                        double.TryParse(number, out doublerino);
                        outputFile2.WriteLine(doublerino); // kirjoitetaan levylle
                    }
                    else
                    {
                        outputFile.WriteLine(integer);



                    }

                } while (number.Length != 0);



                // suljetaan tiedosto
                outputFile.Close();
                outputFile2.Close();

                try
                {
                    using (StreamReader sr = new StreamReader(@"Z:\olio ohjelmointi\Demo07\tehtävä2.integer.txt"))
                    using (StreamReader sr1 = new StreamReader(@"Z:\olio ohjelmointi\Demo07\tehtävä2.txt"))
                    {
                        // read the stream to a string, and write the string to console
                        String line2 = sr.ReadToEnd();
                        String line3 = sr1.ReadToEnd();
                        Console.WriteLine(line2);
                        Console.WriteLine(line3);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
                





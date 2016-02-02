using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            StreamWriter outputFile = new StreamWriter(@"d:\T1Lines.txt");
            
            
            {
                // kysytään käyttäjältä rivi
                do
                {

                    Console.WriteLine("Give a text line (enter stops):");
                    line = Console.ReadLine();
                    outputFile.WriteLine(line); // kirjoitetaan levylle
                }
                while (line.Length != 0);
                }
            // suljetaan tiedosto
            outputFile.Close();

            // avaa tiedosto
            try
            {
                using (StreamReader sr = new StreamReader(@"d:\T1Lines.txt"))
                {
                    // read the stream to a string, and write the string to console
                    String line2 = sr.ReadToEnd();
                    Console.WriteLine(line2);
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
    


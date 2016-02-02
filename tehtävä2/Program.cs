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

           
            {
                // kysytään käyttäjältä rivi
                do
                {
                    StreamWriter outputFile = new StreamWriter(@"d:\integer.txt");
                    Console.WriteLine("Give a number (enter stops):");
                    int integer;
                    
                    bool parsed = Int32.TryParse(number, out integer);
                    if (!parsed)

                        number = Console.ReadLine();

                    outputFile.WriteLine(integer); // kirjoitetaan levylle
                
                else
                {
                    double doublerino;
                    bool parsed2 = Double.TryParse(number, out doublerino);
                        StreamWriter outputFile2 = new StreamWriter(@"d:\double.txt");

                        {
                            while (number.Length != 0) ;
                        }
                    }

                    // suljetaan tiedosto
                    outputFile.Close();

                
    


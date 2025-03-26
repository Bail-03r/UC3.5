using System;
using System.IO;
using System.Text.Json.Serialization;

class Program
{
    static void Main()
    {
        
        while (1+1==2)
        {
            string Choose = Console.ReadLine();

            
            
            
            if (Choose == "write")
            {
                StreamWriter wr = new StreamWriter("output.txt");
                string kek = Console.ReadLine();
                wr.WriteLine(kek);
                wr.Close();
            } else if (Choose == "read") {
                StreamReader rr = new StreamReader("output.txt");
                string line;
                line = rr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = rr.ReadLine();
                }
                rr.Close();
            }
            
        }

    }
}
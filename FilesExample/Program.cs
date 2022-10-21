using System;
using System.IO;

namespace FilesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Sakhile\Noxolo_SARS_Number.pdf";

            Console.WriteLine("Reading File using File.ReadAllText()");
            
            if (File.Exists(path))
            {
                string str = System.IO.File.ReadAllText(path);
                Console.WriteLine(str);
            }
            Console.WriteLine();

            Console.WriteLine("Reading File using File.ReadAllLines()");

            if (File.Exists(path))
            {
                string[] lines = System.IO.File.ReadAllLines(path);

                foreach (string ln in lines)
                    Console.WriteLine(ln);
            }
            Console.WriteLine();

            Console.WriteLine("Reading File using StreamReader");

            if (File.Exists(path))
            {
                StreamReader Textfile = new StreamReader(path);
                string line;

                while ((line = Textfile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                Textfile.Close();

                Console.ReadKey();
            }
            Console.WriteLine();
        }
    }
}

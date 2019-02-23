using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName, fileContent;
            Console.WriteLine("Document\n");
            Console.WriteLine("Please enter your file name.");
            string fileDirectory = @"C:\Users\tyson\source\repos\DocumentProject";
            System.IO.Directory.CreateDirectory(fileDirectory);
            fileName = Console.ReadLine() + ".txt";
            int charCount;


            fileDirectory = System.IO.Path.Combine(fileDirectory, fileName);
            Console.WriteLine("Please enter the content you want in your file.");
            fileContent = Console.ReadLine();

            if (!System.IO.File.Exists(fileName))
            {
                using (System.IO.File.Create(fileName))
                {
                    System.IO.File.WriteAllText(fileDirectory, fileContent);
                }

            }
            else
            {
                Console.WriteLine("That filename is currently being used.\nPress any button to exit program.");
            }


            charCount = fileContent.Length;
            Console.WriteLine("{0} was successfully saved, and it contains {1} characters", fileName, charCount);
            Console.ReadLine();
        }
    }
}

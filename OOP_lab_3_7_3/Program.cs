using System;
using System.IO;

namespace OOP_lab_3_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileInput = new StreamReader("input.txt");

            string sentence = fileInput.ReadLine();

            fileInput.Close();

            string[] elements = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int k = 0;

            foreach(string element in elements)
            {
                int k1 = 0;

                foreach(char c in element)
                {
                    if ((c >= (char)48) && (c <= (char)57)) ++k1;
                }

                if (k1 == element.Length) ++k;
            }

            StreamWriter fileOutput = File.CreateText("output.txt");

            fileOutput.WriteLine(k);

            fileOutput.Close();
        }
    }
}

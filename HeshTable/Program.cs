using System;
using System.IO;

namespace HeshTable
{

    public struct Table
    {
        public string[] Str;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string FileWay = "Input.txt";
            string OutputFileWay = "Output.txt";
            //string[][] table = new string[5][];

            StreamReader sr = new StreamReader(FileWay);
            StreamWriter sw = new StreamWriter(OutputFileWay);

            Table[] table = new Table[5];
            for (int i = 0; i < 5; i++)
            {
                table[i].Str = sr.ReadLine().Split(" ");
            }

            int[] CountOfDeadHeats = new int[5];

            for(int i = 0; i < 5; i++)
            {
                CountOfDeadHeats[i] = Convert.ToInt32(table[i].Str[4]);
            }

            int MaxDeadHeats = 0;
            int IofMaxDeadHeats = 0;
            for (int i = 0; i<5; i++)
            {
                if (CountOfDeadHeats[i] > MaxDeadHeats) 
                { 
                    MaxDeadHeats = CountOfDeadHeats[i];
                    IofMaxDeadHeats = i;
                }
            }
            sw.WriteLine($" Max of dead heats took {table[IofMaxDeadHeats].Str[1]}");
            sw.Close();
        }
    }
}

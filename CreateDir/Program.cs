using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateDir
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainName = default(string);
            string subName = default(string);
            string subCountTemp = default(string);
            int subCount = 0;

            try
            {
                mainName = args[0] ?? "";
                subName = args[1] ?? "";
                subCountTemp = args[2] ?? "0";
                subCount = int.Parse(subCountTemp);
            }
            catch(IndexOutOfRangeException)
            {
                mainName = mainName ?? "";
                subName = subName ?? "";
                subCount = 0;
            }

            while (mainName.Length <= 0)
            {
                try
                {
                    Console.Write("Enter a main folder name: ");
                    mainName = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Error!");
                }
            }

            while (subName.Length <= 0)
            {
                try
                {
                    Console.Write("Enter a sub folder name: ");
                    subName = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Error!");
                }
            }

            while (subCount <= 0)
            {
                try
                {
                    Console.Write("Enter a number of sub folders: ");
                    subCount = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }

            Directory.CreateDirectory(mainName);
            Directory.SetCurrentDirectory(mainName);
            for (int i = 1; i <= subCount; i++)
            {
                Directory.CreateDirectory(subName + "_" + i);
            }
        }
    }
}

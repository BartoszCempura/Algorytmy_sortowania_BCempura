using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy_sortowania_BCempura
{
    internal class DataToTxt
    {
        private static int algorithmsAdded = 0;
        public static void SaveToFile(string fileName, string selectedAlgorithms, double elapsedTime, int totalAlgorithms)
        {

            bool fileExists = File.Exists(fileName);

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                if (!fileExists)
                {
                    writer.WriteLine($"Czas sortowania dla ciągu {fileName} elementowego");
                    writer.WriteLine();
                }
                
                writer.WriteLine($"{selectedAlgorithms} - Czas trwania: {elapsedTime} ms");
                algorithmsAdded++;

                if(algorithmsAdded == totalAlgorithms)
                {
                    writer.WriteLine("--------------------------------------------------");
                    algorithmsAdded = 0;
                }
            }
        }


    }
}

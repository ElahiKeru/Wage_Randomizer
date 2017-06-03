using System;
using System.IO;

namespace WageRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            StreamReader sr = new StreamReader(@"Roster.txt");
            DateTime timeStamp = DateTime.Now;
            StreamWriter sw = new StreamWriter(timeStamp.ToString("yyyyMMdd-HHmmss.fff") + @"_Receipt.txt");
            int platTotal = 0;
            int goldTotal = 0;
            int silverTotal = 0;
            int copperTotal = 0;

            string line = sr.ReadLine();

            while (line != null)
            {
                string[] data = line.Split(',');

                int platBit = 0;
                int goldBit = 0;
                int silverBit = 0;
                int copperBit = 0;

                if (int.Parse(data[1]) > 0)
                {
                    platBit = r.Next(1, int.Parse(data[1])+1);
                }

                if (int.Parse(data[2]) > 0)
                {
                    goldBit = r.Next(1, int.Parse(data[2])+1);
                }

                if (int.Parse(data[3]) > 0)
                {
                    silverBit = r.Next(1, int.Parse(data[3])+1);
                }

                if (int.Parse(data[4]) > 0)
                {
                    copperBit = r.Next(1, int.Parse(data[4])+1);
                }

                sw.WriteLine($"{data[0]} has expended {platBit} Platinum, {goldBit} Gold, {silverBit} Silver, and {copperBit} Copper.");
                Console.WriteLine($"{data[0]} has expended {platBit} Platinum, {goldBit} Gold, {silverBit} Silver, and {copperBit} Copper.");

                platTotal += platBit;
                goldTotal += goldBit;
                silverTotal += silverBit;
                copperTotal += copperBit;

                sw.Flush();
                line = sr.ReadLine();
            }

            Console.WriteLine();
            sw.WriteLine();
            sw.WriteLine($"Totals:\r\nPlatinum: {platTotal}\r\nGold: {goldTotal}\r\nSilver: {silverTotal}\r\nCopper: {copperTotal}");
            Console.WriteLine($"Totals:\r\nPlatinum: {platTotal}\r\nGold: {goldTotal}\r\nSilver: {silverTotal}\r\nCopper: {copperTotal}");
            sw.Flush();

            Console.ReadLine();
        }
    }
}

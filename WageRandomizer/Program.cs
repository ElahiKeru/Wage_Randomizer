using System;
using System.IO;

namespace WageRandomizer
{
    static class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            DateTime timeStamp = DateTime.Now;
            int platTotal = 0;
            int goldTotal = 0;
            int silverTotal = 0;
            int copperTotal = 0;

            using (StreamWriter sw = new StreamWriter(timeStamp.ToString("yyyyMMdd-HHmmss.fff") + @"_Receipt.txt"))
            {
                using (StreamReader sr = new StreamReader(@"Roster.txt"))
                {
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        //data[0] Name
                        //data[1] Platinum
                        //data[2] Gold
                        //data[3] Silver
                        //data[4] Copper
                        //data[5] Active
                        string[] data = line.Split(',');

                        DataCollection dc = new DataCollection();
                        dc.ParseData(data);

                        if (dc.Active)
                        {
                            int platBit = 0;
                            int goldBit = 0;
                            int silverBit = 0;
                            int copperBit = 0;

                            if (dc.Platinum > 0)
                            {
                                platBit = r.Next(1, dc.Platinum + 1);
                            }

                            if (dc.Gold > 0)
                            {
                                goldBit = r.Next(1, dc.Gold + 1);
                            }

                            if (dc.Silver > 0)
                            {
                                silverBit = r.Next(1, dc.Silver + 1);
                            }

                            if (dc.Copper > 0)
                            {
                                copperBit = r.Next(1, dc.Copper + 1);
                            }

                            sw.WriteLine($"{dc.Name} has expended {platBit} Platinum, {goldBit} Gold, {silverBit} Silver, and {copperBit} Copper.");
                            Console.WriteLine($"{dc.Name} has expended {platBit} Platinum, {goldBit} Gold, {silverBit} Silver, and {copperBit} Copper.");

                            platTotal += platBit;
                            goldTotal += goldBit;
                            silverTotal += silverBit;
                            copperTotal += copperBit;

                            sw.Flush();
                        }
                        line = sr.ReadLine();
                    }
                }

                Console.WriteLine();
                sw.WriteLine();
                sw.WriteLine($"Totals:\r\nPlatinum: {platTotal}\r\nGold: {goldTotal}\r\nSilver: {silverTotal}\r\nCopper: {copperTotal}");
                Console.WriteLine($"Totals:\r\nPlatinum: {platTotal}\r\nGold: {goldTotal}\r\nSilver: {silverTotal}\r\nCopper: {copperTotal}");
                sw.Flush();
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WageLibrary;

namespace WageRandomizer
{
    public partial class FRMWageRandomizer : Form
    {
        private Random r;
        private DateTime timeStamp;
        private int platTotal;
        private int goldTotal;
        private int silverTotal;
        private int copperTotal;
        private string receiptFileName;
        private string inputFileName = "Roster.txt";
        private List<WageRecipient> recipients;

        public FRMWageRandomizer()
        {
            InitializeComponent();
        }

        private void FRMWageRandomizer_Load(object sender, EventArgs e)
        {
            PopulateRecipients();
        }

        private void BTNGenerate_Click(object sender, EventArgs e)
        {
            timeStamp = DateTime.Now;
            receiptFileName = $@"Receipts/{timeStamp.ToString("yyyyMMdd_hhmmssfff")}_Receipt.txt";

            GenerateWages();
        }

        private void GenerateWages()
        {
            r = new Random();
            int weekPlat = 0;
            int weekGold = 0;
            int weekSilv = 0;
            int weekCopr = 0;

            FileInfo fi = new FileInfo(receiptFileName);
            if(!fi.Directory.Exists)
            {
                Directory.CreateDirectory(fi.DirectoryName);
            }

            using (StreamWriter sw = new StreamWriter(receiptFileName, true))
            {
                for (int i = 0; i < NUDWeeks.Value; i++)
                {
                    sw.WriteLine($"For Week Number {i + 1}");
                    foreach (WageRecipient wr in recipients)
                    {
                        if (wr.Active)
                        {
                            int platBit = 0;
                            int goldBit = 0;
                            int silvBit = 0;
                            int coprBit = 0;

                            if (wr.Platinum > 0)
                            {
                                platBit = r.Next(1, wr.Platinum + 1);
                            }
                            if (wr.Gold > 0)
                            {
                                goldBit = r.Next(1, wr.Gold + 1);
                            }
                            if (wr.Silver > 0)
                            {
                                silvBit = r.Next(1, wr.Silver + 1);
                            }
                            if (wr.Copper > 0)
                            {
                                coprBit = r.Next(1, wr.Copper + 1);
                            }

                            sw.WriteLine($"{wr.Name} has expended {platBit} Platinum, {goldBit} Gold, {silvBit} Silver, and {coprBit} Copper");
                            weekPlat += platBit;
                            weekGold += goldBit;
                            weekSilv += silvBit;
                            weekCopr += coprBit;
                        }
                    }
                    sw.WriteLine();
                    sw.WriteLine($"Weekly Totals:\r\nPlatinum: {weekPlat}\r\nGold: {weekGold}\r\nSilver: {weekSilv}\r\nCopper: {weekCopr}");
                    sw.WriteLine();

                    platTotal += weekPlat;
                    goldTotal += weekGold;
                    silverTotal += weekSilv;
                    copperTotal += weekCopr;

                    weekPlat = 0;
                    weekGold = 0;
                    weekSilv = 0;
                    weekCopr = 0;
                }
                sw.WriteLine($"Grand Totals:\r\nPlatinum: {platTotal}\r\nGold: {goldTotal}\r\nSilver: {silverTotal}\r\nCopper: {copperTotal}");
                sw.Flush();
                sw.Close();

                Process.Start(fi.FullName);
            }
        }

        private void CLBWageRecipients_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            WageRecipient test = (WageRecipient)CLBWageRecipients.Items[e.Index];
            test.Active = e.NewValue == CheckState.Checked? true : false;
        }

        private void PopulateRecipients()
        {
            recipients = new List<WageRecipient>();
            string line;

            using (StreamReader sr = new StreamReader(inputFileName))
            {
                line = sr.ReadLine();

                while (line != null)
                {
                    recipients.Add(new WageRecipient(line));
                    line = sr.ReadLine();
                }
            }

            foreach(WageRecipient wr in recipients)
            {
                CLBWageRecipients.Items.Add(wr, wr.Active);

            }
        }
    }
}

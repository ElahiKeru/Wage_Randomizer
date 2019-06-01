namespace WageLibrary
{
    public class WageRecipient
    {
        #region Properties
        /// <summary>
        /// holds the Platinum demonination of a person's wage randomization
        /// </summary>
        public int Platinum { get; set; }

        /// <summary>
        /// holds the Gold demonination of a person's wage randomization
        /// </summary>
        public int Gold { get; set; }

        /// <summary>
        /// holds the Silver demonination of a person's wage randomization
        /// </summary>
        public int Silver { get; set; }

        /// <summary>
        /// holds the Copper demonination of a person's wage randomization
        /// </summary>
        public int Copper { get; set; }

        /// <summary>
        /// holds the Name of a person's wage randomization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// holds the Active Flag of a person'a wage randomization
        /// </summary>
        public bool Active { get; set; }
        #endregion

        #region Constructor
        public WageRecipient(string input)
        {
            string[] data = input.Split(',');
            Name = data[0];
            Platinum = int.Parse(data[1]);
            Gold = int.Parse(data[2]);
            Silver = int.Parse(data[3]);
            Copper = int.Parse(data[4]);
            Active = bool.Parse(data[5]);
        }
        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}

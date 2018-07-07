using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageRandomizer
{
    public class DataCollection
    {
        #region Properties
        /// <summary>
        /// holds the Platinum denomination of a person's wage randomization
        /// </summary>
        public int Platinum { get; private set; }
        /// <summary>
        /// holds the Gold denomination of a person's wage randomization
        /// </summary>
        public int Gold { get; private set; }
        /// <summary>
        /// holds the Silver denomination of a person's wage randomization
        /// </summary>
        public int Silver { get; private set; }
        /// <summary>
        /// holds the Copper denomination of a person's wage randomization
        /// </summary>
        public int Copper { get; private set; }
        /// <summary>
        /// holds the Name of a person's wage randomization
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// holds the Acitve Flag of a person's wage randomization
        /// </summary>
        public bool Active { get; private set; }
        #endregion

        //default constructor
        public DataCollection() { }

        public void ParseData(string[] data)
        {
            Name = data[0];
            Platinum = int.Parse(data[1]);
            Gold = int.Parse(data[2]);
            Silver = int.Parse(data[3]);
            Copper = int.Parse(data[4]);
            Active = bool.Parse(data[5]);
        }
    }
}

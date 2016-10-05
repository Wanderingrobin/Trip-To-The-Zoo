using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Mammals
    {
        #region variables
        private string type;
        private bool hasHair;
        private int numberLowerJawBones;

        #endregion

        public Mammals()
        {

        }

        #region Properties

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public bool BaldFuzzyMammal
        {
            set
            {
                if (!hasHair && value == false) 
                {
                    hasHair = true;
                }
                else if (hasHair && value == false)
                {
                    hasHair = false;
                }
            }
        }

        public bool HasHair
        {
            get
            {
                return hasHair;
            }
        }

        public int NumLowerJawBones
        {
            get
            {
                return numberLowerJawBones;
            }
            set
            {
                numberLowerJawBones = value;
            }
        }

#endregion
        #region methods
        #endregion
    }
}

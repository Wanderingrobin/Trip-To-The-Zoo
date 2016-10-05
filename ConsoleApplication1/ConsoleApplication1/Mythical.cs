using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class MythicalCreature
    {
        #region variables
        private string type;
        private bool hasUniquePowers;
        private int numMyths;

        #endregion

        public MythicalCreature()
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

        public bool TotallyNormalAnimal
        {
            set
            {
                if (!hasUniquePowers && value == true)
                {
                    hasUniquePowers = false;
                }
                else if (hasUniquePowers && value == true)
                {
                    hasUniquePowers = true;
                }
            }
        }

        public bool HasMultipleAnimals
        {
            get
            {
                return HasMultipleAnimals;
            }
        }

        public int NumMyths
        {
            get
            {
                return numMyths;
            }
            set
            {
                numMyths = value;
            }
        }

        #endregion
        #region methods
        #endregion
    }
}

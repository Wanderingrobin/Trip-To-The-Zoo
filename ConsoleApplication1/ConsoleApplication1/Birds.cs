using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Birds
    {
        #region variables
        private string type;
        private bool hasFeathers;
        private int numberWings;

        #endregion

        public Birds()
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

        public bool BaldFluffyBird        {
            set
            {
                if (!hasFeathers && value == false)
                {
                    hasFeathers = true;
                }
                else if (hasFeathers && value == false)
                {
                    hasFeathers = false;
                }
            }
        }

        public bool HasFeathers
        {
            get
            {
                return hasFeathers;
            }
        }

        public int NumWings
        {
            get
            {
                return numberWings;
            }
            set
            {
                numberWings = value;
            }
        }

        #endregion
        #region methods
        #endregion
    }
}

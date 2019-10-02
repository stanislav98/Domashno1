using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class Calc
    {

        public string sended { get; set; }
        public double calculation(double val1, double val2)
        {

            if (sended.Equals("Plus"))
            {
                return val1 + val2;
            }
            else if (sended.Equals("Minus"))
            {
                return val1 - val2;
            }
            else if (sended.Equals("Multiply"))
            {
                return val1*val2;
            }
            else {
                return val1 / val2;
            }
        }

    }
}

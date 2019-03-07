using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinerDailySpecials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Day
        {
            SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }
        private void btnGetSpecial_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(txtEnterSpecial.Text);
            string special;
            switch((Day)day)
            {
                case Day.SUNDAY:
                  special = "Chicken and waffles";
                  break;
                case Day.MONDAY:
                  special = "Green eggs and ham";
                  break;
                case Day.TUESDAY:
                  special = "Steak and eggs";
                  break;
                case Day.WEDNESDAY:
                    special = "All you can eat";
                    break;
                case Day.THURSDAY:
                    special = "Kids eat free";
                    break;
                case Day.FRIDAY:
                    special = "Unlimited beer";
                    break;
                case Day.SATURDAY:
                    special = "Fresh cat or dog lol";
                    break;
                default:
                    special = "Invalid day";
                    break;

            }

        }
    }
}

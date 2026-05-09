using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wowdumbcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * variables:
         * wished amount of items
         * current amount of items
         * remaining items until wished amount
         * games until wished amount (assuming you get 5 drops)
         */

        int nWishedAmt, nCurrentAmt, nRemaining, nGamesAmt;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtGamesAmt.Clear();
            try
            {
                nWishedAmt = Convert.ToInt32(txtWishedAmt.Text);
                nCurrentAmt = Convert.ToInt32(txtCurrentAmt.Text);
                if (nWishedAmt < nCurrentAmt)
                {
                    MessageBox.Show("current amount is bigger than wished amount");
                } else if ( nWishedAmt == nCurrentAmt)
                {
                    MessageBox.Show("wished amount is the same as current amount");
                } else
                {
                    nRemaining = nWishedAmt - nCurrentAmt;
                    nGamesAmt = nRemaining / 5;
                    txtGamesAmt.Text = nGamesAmt.ToString();
                }
            }
            catch
            {
                MessageBox.Show("hello wrong input or something");
            }
        }
    }
}

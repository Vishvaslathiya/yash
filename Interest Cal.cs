using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vishvas_Pr_2
{
    public partial class Interest_Cal : Form
    {
        public Interest_Cal()
        {
            InitializeComponent();
        }

        float interest,rate,amt;
        int time;

        private void btn_submit_Click(object sender, EventArgs e)
        {
            tb_interest.Visible = true;
            lbl_result.Visible = true;

            amt = Convert.ToInt32(tb_amt.Text);
            rate = Convert.ToInt32(tb_rate.Text);
            time = Convert.ToInt32(tb_time.Text);

            interest = ((amt*rate*time)/100);

            tb_interest.Text = Convert.ToString( interest);



        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_amt.Text = null;
            tb_interest.Text = null;
            tb_rate.Text = null;
            tb_time.Text = null;
        }
    }
}

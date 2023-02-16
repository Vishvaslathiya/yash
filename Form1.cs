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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }
        //link-https://www.makeuseof.com/windows-forms-calculator-app-build/
        int java, gui, cs, se, linux, enrono, total;
        float percentage;
        string name;

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            lbl_total.Visible =true;
            lbl_percentage.Visible = true;
            lbl_grade.Visible = true;
            tb_total.Visible = true;
            tb_per.Visible = true;
            tb_grade.Visible = true;


            java = Convert.ToInt32(tb_java.Text);
            linux = Convert.ToInt32(tb_linux.Text);
            cs = Convert.ToInt32(tb_cs.Text);
            gui = Convert.ToInt32(tb_gui.Text);
            se = Convert.ToInt32(tb_se.Text);
            name = tb_name.Text; 


            total = java + linux + cs + gui + se;
            percentage=(total*100)/500;

            tb_total.Text =Convert.ToString(total);
            tb_per.Text = Convert.ToString(percentage);


            char grade;
            if (percentage >= 85)
            {
                grade = 'A';
                tb_grade.Text = Convert.ToString(grade);
            }

            else if (percentage >= 70 && percentage <= 84)
            {
                grade = 'B';
                tb_grade.Text =  Convert.ToString(grade);
            }

            else if (percentage >= 55 && percentage <= 69)
            {
                grade = 'C';
                tb_grade.Text = Convert.ToString(grade);
            }
            else if (percentage >= 40 && percentage <= 54)
            {
                grade = 'D';
                tb_grade.Text = Convert.ToString(grade);
            }
            else if (percentage <=39)
            {
                grade = 'F';
                tb_grade.Text = Convert.ToString(grade);
            }



            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_grade.Text = null;
            tb_cs.Text = null;
            tb_enro.Text = null;
            tb_name.Text = null;
            tb_gui.Text = null;
            tb_java.Text = null;
            tb_linux.Text = null;
            tb_se.Text = null;
            tb_total.Text = null;
            tb_per.Text = null;
           

        }
        


       
    }
}

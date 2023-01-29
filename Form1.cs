using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisPasswords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text=="USER")
            {
                textUser.Text = "";
                textUser.ForeColor=Color.DimGray;

            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text=="")
            {
                textUser.Text = "USER";
                textUser.ForeColor = Color.DarkGray;
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text=="PASSWORD")
            {
                textPass.Text = "";
                textPass.ForeColor = Color.DimGray;
                textPass.UseSystemPasswordChar = true;
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text=="")
            {
                textPass.Text = "PASSWORD";
                textPass.ForeColor=Color.DarkGray;
                textPass.UseSystemPasswordChar=false;
            }
        }
    }
}

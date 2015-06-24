using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailEOSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            MailSender myMailSender = new MailSender();
            myMailSender.SendEmployOffer(txtFrom.Text, txtPwd.Text, "moisesmartinezliranzo@gmail.com", txtSubjet.Text, rtBody.Text);
        }

       
    }
}

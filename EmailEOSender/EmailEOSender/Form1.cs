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

            if (comboBox1.SelectedItem.ToString() == "Outlook.com")
            {
                myMailSender.SendEmployOffer(txtFrom.Text, txtPwd.Text, "moisesmartinezliranzo@gmail.com", txtSubjet.Text, rtBody.Text, "smtp-mail.outlook.com");
                MessageBox.Show("Enviado", "Su mensaje ha sido enviado");
                
            }
            else if (comboBox1.SelectedItem.ToString() == "Gmail.com")
            {
                myMailSender.SendEmployOffer(txtFrom.Text, txtPwd.Text, "moisesmartinezliranzo@gmail.com", txtSubjet.Text, rtBody.Text, "smtp.gmail.com");
                MessageBox.Show("Enviado", "Su mensaje ha sido enviado");
            }

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] EmailList = new string[] { "moisesmartinezliranzo@gmail.com", "moisesmartinezliranzo@outlook.com" };
            int cout = EmailList.Length;
            
            for (int i = 0; i < EmailList.Length; i++ ){
                MessageBox.Show("Enviado " + EmailList[i].ToString(), "Contador");  
            }

            MessageBox.Show(cout.ToString(), "Contador");            
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

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
            try
            {
                MailSender myMailSender = new MailSender();

                string[] email = { "moisesmartinezliranzo@gmail.com", "moisesmartinezliranzo@outlook.com" };

                for (int index = 0; index < email.Length; index++ )
                {
                    myMailSender.SendEmployOffer(txtFrom.Text, txtPwd.Text, email[index], txtSubjet.Text, rtBody.Text);
                    //MessageBox.Show(email[index],"Correo");
                    lblMensajesEnviados.Text = (index + 1).ToString();
                }

                MessageBox.Show("Su hoja de vida ha sido enviada", "Enviado");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch(SmtpException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensajesEnviados.Text = "0";
        }

       
    }
}

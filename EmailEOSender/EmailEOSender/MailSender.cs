using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailEOSender
{
    class MailSender
    {      

        public void SendEmployOffer(string emailFrom, string pwd, string emailTo, string subjet, string body)
        {
            SmtpClient client = new SmtpClient();

            client.Host = "smtp.gmail.com";
            client.Port = 25;            
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(emailFrom, pwd);

            MailMessage message = new MailMessage(emailFrom, emailTo, subjet , body);            

            message.BodyEncoding = UTF8Encoding.UTF8;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

           client.Send(message);
            
        }
    }
}

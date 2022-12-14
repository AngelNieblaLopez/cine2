using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        private string senderMail;


        // Inicializamos las propiedades del cliente SMTP, con los parametros.
        protected void initializeSmtpClient(string senderMail, string password, string host, int port, bool ssl)
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
            this.senderMail = senderMail;
        }

        // Metodo para enviar los mensajes de correo a UNO o VARIOS destinatarios'
        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            // create mail message// creamos el mensaje de correo'
            MailMessage mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }

                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);// Enviar Mensaje'
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MailServices
{
    public class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            // Modifique la configuración de conexión al servidor de correo saliente(smtpClient), 
            // de esta clase con tus datos de correo electrónico remitente (El que se encargará de enviar los emails).
            // En caso que uses Gmail como email remitente, debes de Permitir el acceso de aplicaciones
            // poco seguras en el correo para que tu aplicación pueda enviar correos electrónicos.
            // VER TUTORIAL: https://youtu.be/ER3BD8pG-3k?t=1446

            initializeSmtpClient(
                senderMail: "soporteSistema@gmail.com", //Aquí coloque el correo electrónico que se encargará de enviar los mensajes // Place the email address that will send the messages here
                password: "@admin123",
                host: "smtp.gmail.com",
                port: 587,
                ssl: true);

            // Modify the connection settings to the outgoing mail server (smtpClient),
            // of this class with your sender email data (the one that will be in charge of sending the emails).
            // In case you use Gmail as a sender email, you must Allow app access
            // unsecured in the mail so that your application can send emails.
            // SEE TUTORIAL: https://youtu.be/ER3BD8pG-3k?t=1446
        }


    }
}

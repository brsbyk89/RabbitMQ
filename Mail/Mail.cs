using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    public class Mail
    {
        public Mail()
        {
                
        }
        public bool SendMail(string message)
        {
            MailMessage ePosta = new MailMessage();

            ePosta.From = new MailAddress("barisbiyik@hotmail.com");

            ePosta.To.Add("barisbiyik@hotmail.com");

            ePosta.Subject = "RabbitMQ ile Mail Provider";

            ePosta.Body = message;

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("barisbiyik@hotmail.com", "mail sifrem buraya yaz");

            smtp.Host = "smtp.live.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                Console.WriteLine(ex.Message + "Mail Gönderme Hatasi");
            }
            return kontrol;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace appcomics.Integration.Sengrid
{
    public class SendMailIntegration
    {
        public const string SEND_SENDGRID="SENDGRID";
        public const string SEND_REST="REST";

        private string ACCESS_TOKEN ="";
        private string From = "fduartej@usmp.pe"; // settings\sender authentification
        private string FromLabel = "Mail Service"; 

        public async Task SendMail(string correoDestino,string userDestino,string titulo, string contenido,string method){
            ACCESS_TOKEN = System.Environment.GetEnvironmentVariables()["SENDGRID_KEY"].ToString();
            if(method.Equals(SEND_SENDGRID)){
                SendMailSengrid(correoDestino,userDestino, titulo, contenido);
            }else{
                SendMailSengridRest(correoDestino,userDestino,titulo, contenido);
            }
        }
 
        private async Task SendMailSengrid(string correoDestino,string userDestino ,string titulo, string contenido){
            var client = new SendGridClient(ACCESS_TOKEN);
            var from = new EmailAddress(From, FromLabel);
            var subject = titulo;
            var to = new EmailAddress(correoDestino, userDestino);
            var plainTextContent = contenido;
            var htmlContent = "";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }

        private async Task  SendMailSengridRest(string correoDestino,string userDestino,string titulo, string contenido){

        }
        
    }
}
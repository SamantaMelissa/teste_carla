using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Email
    {
        public string assunto{get;set;}
        public string remetente{get; set;}
        public string ccp{get;set;}
        public string corpo{get;set;}

        public void EnviarEmail(assunto, remetente, ccp, corpo){                
            //cria uma mensagem
            MailMessage corpo = new MailMessage();

            //define os endereços
            corpo.From = new MailAddress("macoratti@yahoo.com");
            corpo.To.Add("macoratti@ig.com.br");

            //define o conteúdo
            corpo.Subject = "Este é um simples ,muito simples email";
            corpo.Body = "Este é o corpo do email";

            //envia a mensagem
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Send(corpo);
        }
    }
}
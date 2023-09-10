using Microsoft.AspNetCore.Mvc;
using Send.Email.Models;
using System;
using System.Net;
using System.Net.Mail;

namespace Send.Email.Service
{
    public class SendEmailService
    {
        public SendEmailService()
        {
            
        }
        public bool EnviaMensagem(EmailModel email)
       {
            var smtpClient = new SmtpClientConfig()
                .WidthEnableSsl(true)
                .WidthPort(587)
                .WidthTimeOut(10000)
                .Build();

            var message = new MailMessageBuilder(email.Email)
                .WidthSubject(email.Assunto)
                .WidthBody(email.CorpoMensagem)
                .AsHtml()
                .AddTo(email.Email)
                .Build();

            try
            {
                smtpClient.Send(message);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            
            
       }
    }
}

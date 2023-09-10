using System.Net;
using System.Net.Mail;
using Send.Email.Models;

namespace Send.Email.Service
{
    public class SmtpClientConfig
    {
        private readonly SmtpClient _smtpClient;
        public SmtpClientConfig()
        {
            _smtpClient = new SmtpClient("providerEmailSMTP");
            _smtpClient.Credentials = new NetworkCredential("example@example", "passwordkey");
        }

        public SmtpClientConfig WidthPort(int port)
        {
            _smtpClient.Port = port;
            return this;
        }

        public SmtpClientConfig WidthEnableSsl(bool ssl)
        {
            _smtpClient.EnableSsl = ssl;
            return this;
        }
        public SmtpClientConfig WidthTimeOut(int timeoutMileseconds)
        {
            _smtpClient.Timeout = timeoutMileseconds;
            return this;
        }

        public SmtpClient Build()
        {
            return _smtpClient;
        }
     
    }
}

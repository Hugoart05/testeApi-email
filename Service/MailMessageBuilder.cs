using System.Net.Mail;

namespace Send.Email.Service
{
    public class MailMessageBuilder
    {
        private readonly MailMessage _builder;
        public MailMessageBuilder(string from)
        {
            _builder = new MailMessage { From = new MailAddress(from)};
        }

        public MailMessageBuilder WidthSubject(string subject)
        {
            _builder.Subject = subject;
            return this;
        }
        public MailMessageBuilder WidthBody(string body)
        {
            _builder.Body = body;
            return this;
        }
        public MailMessageBuilder AsHtml()
        {
            _builder.IsBodyHtml = true;
            
            return this;
        }
        public MailMessageBuilder AddTo(string to)
        {
            _builder.To.Add(to);
            return this;
        }

        public MailMessage Build()
        {
            return _builder;
        }
    }
}

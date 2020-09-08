using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using AutoMapper;
using MimeKit;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.DAL.Context;

namespace Thread_.NET.BLL.Services
{
    public sealed class EmailService 
    {
        public void SendEmail(string body, string fromUser, string toUser, string subject) {
            var emailMessage = new MimeMessage();

            var smtpVariable = Environment.GetEnvironmentVariable("SMTP_GMAIL_HOST");
            var fromVariable = fromUser;
            var passwordVariable = Environment.GetEnvironmentVariable("SMTP_PASSWORD_EMAIL");
            var portVariable = Environment.GetEnvironmentVariable("SMTP_PORT");

            MailAddress from = new MailAddress(fromVariable, "Thread .NET");
            MailAddress to = new MailAddress(toUser);
            MailMessage m = new MailMessage(from, to);
            m.Subject = subject;
            m.Body = body; ;
            m.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(smtpVariable, int.Parse(portVariable));
            smtp.Credentials = new NetworkCredential(fromVariable, passwordVariable);
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}

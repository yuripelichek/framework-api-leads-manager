using System;
using System.IO;

namespace Framework.LeadsManager.Infrastructure.Components.Mail
{
    public static class MailSender
    {
        public static void SendMail(string message) 
        {
            File.WriteAllText($"mail{Guid.NewGuid()}.txt", $"{message} to {ToEmail}");
        }     
        public static string ToEmail { get; set; } = "vendas@test.com";
    }
}

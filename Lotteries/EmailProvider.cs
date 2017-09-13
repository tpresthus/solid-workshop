using System;

namespace SingleResponsibility
{
    public class EmailProvider
    {
        public static void SendEmail(string recipient, string subject, string body)
        {
            Console.WriteLine($"Sent email to '{recipient}' with subject '{subject}' and body '{body}'");
        }
    }
}
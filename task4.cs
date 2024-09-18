using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4 задание
//Dependency-Inversion Principle
namespace HomeWork4
{
    public interface IMessageSender
    {
        public void SendMessage(string message);
    }
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }
    public class NotificationService
    {
        private IMessageSender Sender;
        public NotificationService(IMessageSender sender)
        {
            Sender = sender;
        }
        public void SendNotification(string message)
        {
            Sender.SendMessage(message);
        }
    }

}

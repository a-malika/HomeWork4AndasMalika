using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1 задание
//Single-Responsibility Principle
namespace HomeWork4
{
    public class Order
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
    public class PriceCalculator
    {
        public double CalculateTotalPrice(Order order)
        {
            // Рассчет стоимости с учетом скидок
            return order.Quantity * order.Price * 0.9;
        }
    }
    public class PaymentHandler
    {
        public void ProcessPayment(Order order, string paymentDetails)
        {
            // Логика обработки платежа
            Console.WriteLine("Payment processed using: " + paymentDetails);
        }
    }
    public class Notification
    {
        public void SendConfirmationEmail(Order order, string email)
        {
            // Логика отправки уведомления
            Console.WriteLine("Confirmation email sent to: " + email);
        }
    }
}

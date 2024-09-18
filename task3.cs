using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3 задание
//Interface Segregation Principle
namespace HomeWork4
{
    public interface IPrinterPrint
    {
        void Print(string content);
    }
    public interface IPrinterScan
    {
        void Scan(string content);
    }
    public interface IPrinterFax
    {
        void Fax(string content);
    }
    public class AllInOnePrinter : IPrinterPrint, IPrinterScan, IPrinterFax
    {
        public void Print(string content)
        {
            Console.WriteLine("Printing: " + content);
        }

        public void Scan(string content)
        {
            Console.WriteLine("Scanning: " + content);
        }

        public void Fax(string content)
        {
            Console.WriteLine("Faxing: " + content);
        }
    }
    public class BasicPrinter : IPrinterPrint
    {
        public void Print(string content)
        {
            Console.WriteLine("Printing: " + content);
        }
    }

}

using System;
namespace Lab1TMPS
{


    // Single Responsibility Principle (SRP)
    public class Order
    {
        public void Process()
        {
            Console.WriteLine("Processing order...");
        }
    }

    public class EmailNotifier
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending email notification...");
        }
    }

    // Open-Closed Principle (OCP)
    public interface IPaymentMethod
    {
        void ProcessPayment();
    }

    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }

    public class PaypalPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment...");
        }
    }

    public class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void ProcessPayment()
        {
            _paymentMethod.ProcessPayment();
        }
    }

    // Liskov Substitution Principle (LSP)
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    // Interface Segregation Principle (ISP)
    public interface IEat
    {
        void Eat();
    }

    public interface ISleep
    {
        void Sleep();
    }

    public class Cat : IEat, ISleep
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    // Dependency Inversion Principle (DIP)
    public interface IDataSource
    {
        string GetData();
    }

    public class Database : IDataSource
    {
        public string GetData()
        {
            return "Data from database";
        }
    }

    public class File : IDataSource
    {
        public string GetData()
        {
            return "Data from file";
        }
    }

    public class DataProcessor
    {
        private readonly IDataSource _dataSource;

        public DataProcessor(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void ProcessData()
        {
            string data = _dataSource.GetData();
            Console.WriteLine("Processing data: " + data);
        }
    }
}

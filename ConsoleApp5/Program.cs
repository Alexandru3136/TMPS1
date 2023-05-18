using System;
namespace Lab1TMPS
{
    // Main program
    public class Program
    {
        public static void Main(string[] args)
        {
            // Single Responsibility Principle (SRP)
            Order order = new Order();
            order.Process();

            EmailNotifier emailNotifier = new EmailNotifier();
            emailNotifier.SendEmail();

            // Open-Closed Principle (OCP)
            PaymentProcessor paymentProcessor = new PaymentProcessor(new CreditCardPayment());
            paymentProcessor.ProcessPayment();

            paymentProcessor = new PaymentProcessor(new PaypalPayment());
            paymentProcessor.ProcessPayment();

            // Liskov Substitution Principle (LSP)
            Animal animal = new Dog();
            animal.MakeSound();

            // Interface Segregation Principle (ISP)
            Cat cat = new Cat();
            cat.Eat();

            // Dependency Inversion Principle (DIP)
            DataProcessor dataProcessor = new DataProcessor(new Database());
            dataProcessor.ProcessData();

            dataProcessor = new DataProcessor(new File());
            dataProcessor.ProcessData();
        }
    }
}

using SolidPaymentSystem.Interfaces;
using SolidPaymentSystem.PaymentMethods;
using SolidPaymentSystem.Services;

class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// This method demonstrates the usage of different payment methods, payment processing, refunds, and order processing.
    /// </summary>
    static void Main(string[] args)
    {
        // Creating instances of payment methods
        // The payment methods can be easily extended to include others like cryptocurrency, bank transfers, etc.
        IPaymentMethod creditCardPayment = new CreditCardPayment();
        IPaymentMethod payPalPayment = new PayPalPayment();

        // Processing payments using PaymentProcessor
        // PaymentProcessor uses the IPaymentMethod abstraction to process the payment
        PaymentProcessor paymentProcessor = new(creditCardPayment);
        paymentProcessor.ProcessPayment(100.0m); // Payment with Credit Card

        PaymentProcessor paymentProcessor2 = new(payPalPayment);
        paymentProcessor2.ProcessPayment(200.0m); // Payment with PayPal

        // Using the system for refunds with IRefundable interface
        // The Refund functionality is only available for payment methods that implement IRefundable
        IRefundable refundablePayment = (IRefundable)creditCardPayment;
        refundablePayment.Refund(50.0m); // Refund to Credit Card

        // Using OrderProcessor to process orders
        // The OrderProcessor delegates payment processing to the IPaymentMethod implementation
        OrderProcessor orderProcessor = new(creditCardPayment);
        orderProcessor.ProcessOrder(150.0m); // Process Credit Card order
    }
}

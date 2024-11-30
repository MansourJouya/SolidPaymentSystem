using SolidPaymentSystem.Interfaces;

namespace SolidPaymentSystem.PaymentMethods
{
    /// <summary>
    /// Represents a payment method using PayPal.
    /// This class implements the IPaymentMethod interface to process PayPal payments.
    /// </summary>
    public class PayPalPayment : IPaymentMethod
    {
        /// <summary>
        /// Processes a payment using PayPal for the specified amount.
        /// This method outputs a message indicating that the PayPal payment has been processed.
        /// </summary>
        /// <param name="amount">The amount to be paid using PayPal.</param>
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}.");
        }
    }
}

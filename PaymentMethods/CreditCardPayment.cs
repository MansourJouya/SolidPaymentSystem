using SolidPaymentSystem.Interfaces;

namespace SolidPaymentSystem.PaymentMethods
{
    /// <summary>
    /// Represents a payment method using a credit card.
    /// This class implements the IPaymentMethod interface for payment processing 
    /// and the IRefundable interface for processing refunds.
    /// </summary>
    public class CreditCardPayment : IPaymentMethod, IRefundable
    {
        /// <summary>
        /// Processes a payment using a credit card for the specified amount.
        /// This method outputs a message indicating that the payment has been processed.
        /// </summary>
        /// <param name="amount">The amount to be paid using the credit card.</param>
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount}.");
        }

        /// <summary>
        /// Processes a refund to a credit card for the specified amount.
        /// This method outputs a message indicating that the refund has been processed.
        /// </summary>
        /// <param name="amount">The amount to be refunded to the credit card.</param>
        public void Refund(decimal amount)
        {
            Console.WriteLine($"Refunding Credit Card payment of {amount}.");
        }
    }
}

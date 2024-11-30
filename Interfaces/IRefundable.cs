namespace SolidPaymentSystem.Interfaces
{
    /// <summary>
    /// Defines the contract for refundable payment methods. 
    /// Any class implementing this interface must provide 
    /// the logic to process refunds.
    /// </summary>
    public interface IRefundable
    {
        /// <summary>
        /// Processes a refund for the specified amount.
        /// This method is implemented by payment methods that support refunds (e.g., CreditCardPayment).
        /// </summary>
        /// <param name="amount">The amount to be refunded.</param>
        void Refund(decimal amount);
    }
}

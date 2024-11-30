namespace SolidPaymentSystem.Interfaces
{
    /// <summary>
    /// Defines the contract for payment methods. 
    /// Any class implementing this interface must provide 
    /// the logic to process payments.
    /// </summary>
    public interface IPaymentMethod
    {
        /// <summary>
        /// Processes a payment with the specified amount.
        /// This method is implemented by each payment method (e.g., CreditCardPayment, PayPalPayment).
        /// </summary>
        /// <param name="amount">The amount to be paid.</param>
        void Pay(decimal amount);
    }
}

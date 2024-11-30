using SolidPaymentSystem.Interfaces;

namespace SolidPaymentSystem.Services
{
    /// <summary>
    /// Processes payments using the provided payment method.
    /// This class ensures that payments are processed correctly using the selected method.
    /// </summary>
    public class PaymentProcessor
    {
        private readonly IPaymentMethod paymentMethod;

        /// <summary>
        /// Initializes a new instance of the PaymentProcessor class with a specified payment method.
        /// </summary>
        /// <param name="paymentMethod">The payment method used to process the payment.</param>
        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        /// <summary>
        /// Processes a payment by invoking the Pay method on the provided payment method.
        /// </summary>
        /// <param name="amount">The amount to be paid.</param>
        public void ProcessPayment(decimal amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}

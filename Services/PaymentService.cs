using SolidPaymentSystem.Interfaces;

namespace SolidPaymentSystem.Services
{
    /// <summary>
    /// A service that processes payments using a specified payment method.
    /// This class facilitates the processing of payments through various payment methods.
    /// </summary>
    public class PaymentService
    {
        /// <summary>
        /// Processes a payment using the provided payment method.
        /// </summary>
        /// <param name="paymentMethod">The payment method used to process the payment.</param>
        /// <param name="amount">The amount to be paid.</param>
        public void Process(IPaymentMethod paymentMethod, decimal amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}

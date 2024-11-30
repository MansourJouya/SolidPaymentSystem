using SolidPaymentSystem.Interfaces;

namespace SolidPaymentSystem.Services
{
    /// <summary>
    /// Processes orders by using the provided payment method.
    /// This class ensures that the payment for an order is processed correctly.
    /// </summary>
    public class OrderProcessor
    {
        private readonly IPaymentMethod paymentMethod;

        /// <summary>
        /// Initializes a new instance of the OrderProcessor class with a specified payment method.
        /// </summary>
        /// <param name="paymentMethod">The payment method used to process the payment.</param>
        public OrderProcessor(IPaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        /// <summary>
        /// Processes an order by making the payment using the specified payment method.
        /// </summary>
        /// <param name="amount">The amount to be paid for the order.</param>
        public void ProcessOrder(decimal amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}

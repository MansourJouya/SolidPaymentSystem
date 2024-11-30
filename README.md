# SolidPaymentSystem

**SolidPaymentSystem** is a robust payment processing system designed with a focus on adhering to the **SOLID principles** of object-oriented design. The system is built to be modular, flexible, and easy to maintain, ensuring a smooth experience for both developers and users. It enables the processing of payments through various methods, including **Credit Card** and **PayPal**, and extends functionality to support refunds for supported payment methods.

By following the **SOLID principles**, this system ensures that it remains extensible and scalable, allowing new payment methods and features to be integrated with minimal disruption to the existing codebase. The architecture emphasizes **separation of concerns**, making it easy to manage different aspects of payment processing, such as handling various payment gateways and refunds, in a clean and organized manner.

With its modular structure, the **SolidPaymentSystem** not only simplifies integration but also provides a clear and maintainable path for future enhancements, ensuring that it can evolve alongside the needs of the business.

---

### SOLID Principles

This system is a practical example of how the **SOLID principles** can be applied to a payment processing system, demonstrating good object-oriented design practices.

1. **Single Responsibility Principle (SRP)**: Each class in the system has one responsibility. For example:
   - `PaymentProcessor` is responsible for processing payments.
   - `CreditCardPayment` and `PayPalPayment` handle their respective payment methods.
   - `OrderProcessor` is responsible for processing orders.

2. **Open/Closed Principle (OCP)**: The system is **open for extension** but **closed for modification**. New payment methods (e.g., cryptocurrency payments) can be added by simply creating new classes that implement the `IPaymentMethod` interface, without modifying existing classes like `PaymentProcessor` or `OrderProcessor`.

3. **Liskov Substitution Principle (LSP)**: Derived classes (`CreditCardPayment`, `PayPalPayment`) can be substituted wherever the base interface (`IPaymentMethod`) is used. For example:
   - `PaymentProcessor` and `OrderProcessor` can process payments using any class that implements `IPaymentMethod`.

4. **Interface Segregation Principle (ISP)**: The system adheres to the Interface Segregation Principle by creating specific interfaces for different functionalities:
   - `IPaymentMethod` handles payment functionality.
   - `IRefundable` handles refund functionality.
   - Classes implement only the interfaces they need, avoiding unnecessary dependencies.

5. **Dependency Inversion Principle (DIP)**: High-level modules like `PaymentProcessor` and `OrderProcessor` depend on abstractions (i.e., interfaces like `IPaymentMethod`), not concrete implementations (e.g., `CreditCardPayment` or `PayPalPayment`). This enhances flexibility and testability by enabling easy swapping of payment methods.

This project is an excellent example of how the **SOLID principles** help create a maintainable, flexible, and scalable system while ensuring that the design remains clean and easy to extend with minimal effort.

---

## Features

- **Payment Processing**: Support for different payment methods such as Credit Card and PayPal.
- **Refunds**: Capability to handle refunds, particularly for Credit Card payments.
- **Extensibility**: Easily extendable with new payment methods or services without modifying existing code.
- **SOLID Principles**: The project follows the five SOLID principles for object-oriented design, ensuring clean, maintainable, and scalable code.

## Folder Structure

The project is organized into the following folder structure:

```
SolidPaymentSystem
│
├── Interfaces
│   ├── IPaymentMethod.cs
│   ├── IRefundable.cs
│
├── PaymentMethods
│   ├── CreditCardPayment.cs
│   ├── PayPalPayment.cs
│
├── Services
│   ├── PaymentProcessor.cs
│   ├── PaymentService.cs
│   └── OrderProcessor.cs
│
└── Program.cs
```

### Folder Breakdown

1. **Interfaces**:
   - Contains the definitions for `IPaymentMethod` (payment functionality) and `IRefundable` (refund functionality).
   
2. **PaymentMethods**:
   - Contains the concrete implementations of payment methods such as `CreditCardPayment` and `PayPalPayment`.

3. **Services**:
   - Contains the core logic for payment and order processing:
     - `PaymentProcessor`: Responsible for processing payments.
     - `PaymentService`: A service to process payments using different payment methods.
     - `OrderProcessor`: Handles order processing and delegates payment processing.

4. **Program.cs**:
   - The entry point for running the application, demonstrating how payments and refunds are processed.

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/SolidPaymentSystem.git
   ```

2. Open the project in Visual Studio.

3. Build and run the project.

4. The `Program.cs` will demonstrate the usage of different payment methods and order processing:
   - Payment with `CreditCardPayment`
   - Payment with `PayPalPayment`
   - Refund using `CreditCardPayment`

## Example Usage

```csharp
// Create instances of payment methods
IPaymentMethod creditCardPayment = new CreditCardPayment();
IPaymentMethod payPalPayment = new PayPalPayment();

// Process payments
PaymentProcessor paymentProcessor = new PaymentProcessor(creditCardPayment);
paymentProcessor.ProcessPayment(100.0m); // Payment with Credit Card

PaymentProcessor paymentProcessor2 = new PaymentProcessor(payPalPayment);
paymentProcessor2.ProcessPayment(200.0m); // Payment with PayPal

// Process refunds (only for refundable payments)
IRefundable refundablePayment = (IRefundable)creditCardPayment;
refundablePayment.Refund(50.0m); // Refund to Credit Card

// Process orders
OrderProcessor orderProcessor = new OrderProcessor(creditCardPayment);
orderProcessor.ProcessOrder(150.0m); // Process Credit Card order
```

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-new-payment-method`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new payment method'`).
5. Push to the branch (`git push origin feature-new-payment-method`).
6. Create a new pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details.

For inquiries, you can contact me at: [jouya.m@gmail.com](mailto:jouya.m@gmail.com)


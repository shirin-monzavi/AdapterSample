using AdapterSample.Adapters;
using AdapterSample.Adaptesses;
using AdapterSample.Targets;

TranditionalPayment oldPaymentSystem = new();

IPaymentProcessor paymentProcessor = new PaymentAdapter(oldPaymentSystem);

paymentProcessor.ProcessPayment(100.00m); 

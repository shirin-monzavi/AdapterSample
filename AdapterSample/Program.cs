using AdapterSample.Adapters;
using AdapterSample.Adaptesses;
using AdapterSample.Targets;

TranditionalPayment tranditionalPayment = new();

IPaymentProcessor paymentProcessor = new PaymentAdapter(tranditionalPayment);

paymentProcessor.ProcessPayment(100.00m); 

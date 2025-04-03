namespace AdapterSample.Targets;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

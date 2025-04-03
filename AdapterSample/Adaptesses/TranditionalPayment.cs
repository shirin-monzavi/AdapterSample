namespace AdapterSample.Adaptesses;

public class TranditionalPayment
{
    public void MakePayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of ${amount} using TraditionalPaymentSystem.");
    }
}

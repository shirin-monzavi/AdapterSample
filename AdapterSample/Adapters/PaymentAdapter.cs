using AdapterSample.Adaptesses;
using AdapterSample.Targets;

namespace AdapterSample.Adapters;

public class PaymentAdapter : IPaymentProcessor
{
    #region Field
    private readonly TranditionalPayment _traditionalPayment;
    #endregion

    public PaymentAdapter(TranditionalPayment tranditionalPayment)
    {
        _traditionalPayment = tranditionalPayment;
    }

    public void ProcessPayment(decimal amount)
    {
        _traditionalPayment.MakePayment(amount);
    }
}

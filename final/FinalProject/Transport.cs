public class Transport : Budget
{
    public Transport(string category, int amount) : base("Transport       ", amount)
    {
    }
    public override int BudgetAppropriation()
    {
        int _appropriation = (GetAmount() * 15/100);
        return _appropriation;
    }
}
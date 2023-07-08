public class Insurance : Budget
{
    public Insurance(string category, int amount) : base("Insurance       ", amount)
    {
    }
    public override int BudgetAppropriation()
    {
        int _appropriation = (GetAmount() * 7/100);
        return _appropriation;
    }
}
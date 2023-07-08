public class Utilities : Budget
{
    public Utilities(string category, int amount) : base("Utilities       ", amount)
    {
    }
    public override int BudgetAppropriation()
    {
        int _appropriation = (GetAmount() * 6/100);
        return _appropriation;
    }
}
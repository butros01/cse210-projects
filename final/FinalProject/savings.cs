public class Savings : Budget
{
    public Savings(string category, int amount) : base("Savings         ", amount)
    {
    }
    public override int BudgetAppropriation()
    {
        int _appropriation = (GetAmount() * 7/100);
        return _appropriation;
    }
}
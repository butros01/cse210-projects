public class Miscellaneous    : Budget
{
    public Miscellaneous   (string category, int amount) : base("Miscellaneous   ", amount)
    {
    }
    public override int BudgetAppropriation()
    {
        int _appropriation = (GetAmount() * 5/100);
        return _appropriation;
    }
}
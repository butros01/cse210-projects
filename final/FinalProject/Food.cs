public class Food : Budget
{
    public Food(string category, int amount) : base("Food            ", amount)
    {
    }
    public override int BudgetAppropriation()
    {
        int _appropriation = (GetAmount() * 2/10);
        return _appropriation;
    }
}
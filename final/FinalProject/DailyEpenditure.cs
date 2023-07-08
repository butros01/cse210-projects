public class DailyExpenditure : Budget
{
    public DailyExpenditure(string category, int amount) : base($"DailyExpenditure", amount)
    {
    }
    public override int BudgetAppropriation()
    {
        int _appropriation = (GetAmount() * 1/10);
        return _appropriation;
    }
}
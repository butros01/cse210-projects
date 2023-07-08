public class Housing : Budget
{
    public Housing(string category, int amount) : base("Housing         ", amount)
    {
    }
    public override int BudgetAppropriation()
    {
        int _appropriation = (GetAmount() * 3/10);
        return _appropriation;
    }
}
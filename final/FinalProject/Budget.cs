public  class Budget
{
    private string _category;
    private int _amount;
    
    public Budget(string category, int amount)
    {
        _category = category;
        _amount = amount;
    }
    
    public void DisplayEstimate()
    {
        
        Console.WriteLine($"    {_category}: {BudgetAppropriation()}");
    }
    public virtual int BudgetAppropriation()
    {
        return _amount;
    }

    public int GetAmount()
    {
        return _amount;
    }
    
}
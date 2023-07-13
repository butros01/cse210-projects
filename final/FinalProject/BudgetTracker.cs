public class BudgetTracker
{
    List<Budget> categories;
    List<string> items;

    public BudgetTracker()
    {
        categories = new List<Budget>();
        items = new List<string>();
    }

    public void Dispaly()
    {
        // Request user for monthly income
        Console.Write("Enter your monthly income: $");
        int income = int.Parse(Console.ReadLine());
        Insurance insurance = new Insurance(string.Empty, income);
        categories.Add(insurance);
        Housing housing = new Housing(string.Empty, income);
        categories.Add(housing);
        Utilities utilities = new Utilities(string.Empty, income);
        categories.Add(utilities);
        Food food = new Food(string.Empty, income);
        categories.Add(food);
        Miscellaneous miscellaneous = new Miscellaneous(string.Empty, income);
        categories.Add(miscellaneous);
        Transport transport = new Transport(string.Empty, income);
        categories.Add(transport);
        DailyExpenditure dailyExpenditure = new DailyExpenditure(string.Empty, income);
        categories.Add(dailyExpenditure);
        Savings savings = new Savings(string.Empty, income);
        categories.Add(savings);

        Console.WriteLine($"Estimated budget Appropriation:");
        int total = 0;
        foreach (Budget category in categories)
        {
            category.DisplayEstimate();
            total += category.BudgetAppropriation();
            
        }
        Console.WriteLine($"--------------------------------\n    Total          : {total}\n--------------------------------");

        Console.Write("\nTime to track your Daily Expediture\n");
        // Request user for daily expenditure
        Console.Write("\nEnter how much you spend today?: $");
        decimal expenditure = Convert.ToDecimal(Console.ReadLine());

        // Ask questions pertaining to spending behaviors
        
        Console.WriteLine($"How did you spend the $ {expenditure}? List the items you bought and type ''Quit'' when done: ");
        string userInput = Console.ReadLine();
        while (userInput.ToLower() != "quit")
        {
            userInput = Console.ReadLine(); 
        }
        
        Console.WriteLine("Ponder on the item(s) you consider you could have done without. How much did the unneccesary item(s) cost you?: ");
        string unneccesaryItemsCost = Console.ReadLine();

        Console.WriteLine($"You could have saved $ {unneccesaryItemsCost}");
        // Calculate total expenditure for the day
        decimal totalExpenditure = expenditure;

        // Provide advice message based on daily expenditure
        if (totalExpenditure > dailyExpenditure.BudgetAppropriation() * 0.1m)
        {
            Console.WriteLine("WARNING!!:\nYou have spent more than 10% of your appropriation for Monthly-Daily Expenditure . Consider reducing your expenses.");
        }
        else
        {
            Console.WriteLine("CONGRATULATIONS!:\nYou are doing well in managing your daily expenses. Keep it up!");
        }
    }  
}
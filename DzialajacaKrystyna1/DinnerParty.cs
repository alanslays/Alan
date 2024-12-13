public class DinnerParty
{
    public const int CostOfFoodPerPerson = 25;
    public int NumberOfPeople;
    public decimal CostOfBeveragesPerPerson;
    public decimal CostOfDecorations = 0;

    public void setHealthyOption(bool healthyOption)
    {
        if (healthyOption)
        {
            CostOfBeveragesPerPerson = 5.00M;
        }
        else
        {
            CostOfBeveragesPerPerson = 20.00M;
        }
    }

    public void CalculateCostOfDecorations(bool fancy)
    {
        if (fancy)
        {
            CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
        }
        else
        {
            CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }
    }

    public decimal CalculateCost(bool healthyOption)
    {
        decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
        int a = Convert.ToInt32(totalCost);
        if (healthyOption)
        {
            return (decimal)(a * .95);
        }
        else
        {
            return totalCost;
        }
    }
}
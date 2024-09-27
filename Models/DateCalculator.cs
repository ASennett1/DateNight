namespace DateNight.Models;

public class DateCalculator
{
    public string CoffeeCost { get; set; }
    public string DinnerCost { get; set; }
    public string MovieCost { get; set; }

    public string GetTotalCost()
    {
        decimal decCoffee, decDinner, decMovie;

        if (!Decimal.TryParse(CoffeeCost, out decCoffee))
        {
            if (!string.IsNullOrEmpty(CoffeeCost))
            {
                throw new Exception("invalid coffee cost");
            }
        }
        
        if (!Decimal.TryParse(DinnerCost, out decDinner))
        {
            if (!string.IsNullOrEmpty(DinnerCost))
            {
                throw new Exception("invalid dinner cost");
            }
        }
        
        if (!Decimal.TryParse(MovieCost, out decMovie))
        {
            if (!string.IsNullOrEmpty(MovieCost))
            {
                throw new Exception("invalid movie cost");
            }
        }
        return (decCoffee + decDinner + decMovie).ToString("c");
    }
}
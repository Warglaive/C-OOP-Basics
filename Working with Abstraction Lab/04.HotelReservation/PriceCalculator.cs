using System;
using System.Collections.Generic;
using System.Text;


public class PriceCalculator
{
    private decimal pricePerDay;
    private int daysCount;

    public enum Season
    {
        Spring = 2,
        Summer = 4,
        Autumn = 1,
        Winter = 3
    }

    public enum DiscountType
    {
        None,
        SecondVisit = 10,
        VIP = 20
    }

    public decimal CalculatePrice(decimal pricePerDay,
        int daysCount, Season season, DiscountType discount)
    {
        //
        var defaultPricePerDay = pricePerDay * daysCount;
        var newPrice = 0m;
        if (season == Season.Autumn)
        {
            newPrice = defaultPricePerDay *= (decimal)season;
            newPrice = calculateDiscount(newPrice, discount, defaultPricePerDay);
        }
        else if (season == Season.Spring)
        {
            newPrice = defaultPricePerDay *= (decimal)season;
            newPrice = calculateDiscount(newPrice, discount, defaultPricePerDay);
        }
        else if (season == Season.Summer)
        {
            newPrice = defaultPricePerDay *= (decimal)season;
            newPrice = calculateDiscount(newPrice, discount, defaultPricePerDay);
        }
        else
        {
            newPrice = defaultPricePerDay *= (decimal)season;
            newPrice = calculateDiscount(newPrice, discount, defaultPricePerDay);
        }
        return newPrice;
    }

    private static decimal calculateDiscount(decimal newPrice, DiscountType discount, decimal defaultPricePerDay)
    {
        switch (discount)
        {
            case DiscountType.VIP:
                newPrice = defaultPricePerDay * 0.80m;
                break;
            case DiscountType.SecondVisit:
                newPrice = defaultPricePerDay * 0.90m;
                break;
            case DiscountType.None:
                //no discount
                break;
        }
        return newPrice;
    }
}
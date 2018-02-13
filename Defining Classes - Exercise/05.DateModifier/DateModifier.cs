using System;


class DateModifier
{
    public void TakeAndCalculateDate(string firstDate, string secondDate)
    {
        var currentFirstDate = DateTime.Parse(firstDate);
        var currentSecondDate = DateTime.Parse(secondDate);

        if (currentFirstDate > currentSecondDate)
        {
            Console.WriteLine((currentFirstDate - currentSecondDate).Days);
        }
        else if (currentSecondDate > currentFirstDate)
        {
            Console.WriteLine((currentSecondDate - currentFirstDate).Days);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

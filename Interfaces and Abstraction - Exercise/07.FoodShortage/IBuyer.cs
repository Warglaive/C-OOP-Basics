using System;
using System.Collections.Generic;
using System.Text;


public interface IBuyer
{
    int BuyFood(string name);
    int Food { get; }
}

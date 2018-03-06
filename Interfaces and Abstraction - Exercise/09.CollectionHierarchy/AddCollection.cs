using System;
using System.Collections.Generic;
using System.Text;


public class AddCollection : IAddToTheEnd
{
    public int AddEnd(string item, List<string> collection)
    {
        collection.Add(item);
        return collection.IndexOf(item);
    }
}
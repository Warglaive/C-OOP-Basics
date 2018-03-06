using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class MyList : IAddToTheStart, IRemoveFirst, IDisplayUsed
{
    public int AddStart(string item, List<string> collection)
    {
        collection.Insert(0, item);
        return collection.IndexOf(item);
    }

    public string RemoveFirst(List<string> collection)
    {
        collection.RemoveAt(0);
        var removedItem = collection[0];
        return removedItem;
    }

    public int Used(List<string> collection)
    {
        return collection.Count;
    }
}
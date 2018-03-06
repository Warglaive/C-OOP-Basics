using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AddRemoveCollection : IAddToTheStart, IRemoveLast
{
    public int AddStart(string item, List<string> collection)
    {
        collection.Insert(0, item);
        return collection.IndexOf(item);
    }

    public string RemoveLast(List<string> collection)
    {
        //maybe bug
        var removedItem = collection.TakeLast(1);
        collection.RemoveAt(collection.Count - 1);
        return removedItem.ToString();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Exceptions
{
    public class ExceptionMessages
    {
        public Exception MustBeAliveException()
        {
            throw new InvalidOperationException("Must be alive to perform this action!");
        }

        public Exception BagIsFullException()
        {
            throw new InvalidOperationException("Bag is full!");
        }

        public Exception BagIsEmpty()
        {
            throw new InvalidOperationException("Bag is empty!");
        }

        public Exception ItemDosentExist(string name)
        {
            throw new ArgumentException($"No item with name {name} in bag!");
        }

        public Exception NullOrWhiteSpacException()
        {
            throw new ArgumentException("Name cannot be null or whitespace!");
        }
    }
}

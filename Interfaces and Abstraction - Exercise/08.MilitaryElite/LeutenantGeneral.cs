using System;
using System.Collections.Generic;
using System.Text;


public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private ICollection<ISoldier> privates;

    public LeutenantGeneral(int id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName, salary)
    {
        privates = new List<ISoldier>();
    }

    public IReadOnlyCollection<ISoldier> Privates =>
        (IReadOnlyCollection<ISoldier>)this.privates;

    public void AddPrivate(ISoldier soldier)
    {
        this.privates.Add(soldier);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine("Privates:");

        foreach (var currentPrivate in Privates)
        {
            sb.AppendLine($"  {currentPrivate.ToString()}");
        }
        var result = sb.ToString().TrimEnd();
        return result;
    }
}
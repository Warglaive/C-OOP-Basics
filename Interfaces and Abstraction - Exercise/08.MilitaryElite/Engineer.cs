using System;
using System.Collections.Generic;
using System.Text;


public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = new List<IRepair>();
    }

    private ICollection<IRepair> repairs;
    public IReadOnlyCollection<IRepair> Repairs
        => (IReadOnlyCollection<IRepair>)repairs;

    public void AddRepair(IRepair repair)
    {
        repairs.Add(repair);
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine($"{nameof(this.Corps)}: {this.Corps.ToString()}")
            .AppendLine($"{nameof(this.Repairs)}:");

        foreach (var currentRepair in this.Repairs)
        {
            sb.AppendLine($"  {currentRepair.ToString()}");
        }
        var result = sb.ToString().TrimEnd();
        return result;
    }
}
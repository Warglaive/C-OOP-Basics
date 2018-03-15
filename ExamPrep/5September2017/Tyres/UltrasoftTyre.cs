using System;


public class UltrasoftTyre : Tyre
{
    private double degradation;

    public UltrasoftTyre(double hardness, double grip)
        : base(hardness)
    {
        this.Grip = grip;
    }

    private double Grip { get; }

    public override string Name => "Ultrasoft";

    public override double Degradation
    {
        get => degradation;
        protected set
        {
            if (value < 30)
            {
                throw new ArgumentException("Blown tyre");
            }
            degradation = value;
        }
    }

    public override void ReduceDegradation()
    {
        this.Degradation -= (this.Hardness + this.Grip);
    }
}
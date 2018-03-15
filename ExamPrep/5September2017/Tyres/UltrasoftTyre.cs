using System;


public class UltrasoftTyre : Tyre
{
    //Positive property grip, floating point
    private double grip;

    public double Grip
    {
        get { return grip; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Grip is negative");
            }
            grip = value;
        }
    }

    public UltrasoftTyre(string name, double hardness)
    : base(name, hardness)
    {
        name = "Ultrasoft";
        //
        this.Degradation -= (hardness + this.Grip);
        if (this.Degradation < 30)
        {
            throw new ArgumentException("UltrasoftTyre blows up, because of degradation < 30");
        }
    }
}
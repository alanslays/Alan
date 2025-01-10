using System;

interface IClown
{
    string FunnyThingIHave { get; }
    void Honk();
}

interface IScaryClown : IClown
{
    string ScaryThingIHave { get; }
    void ScareLittleChildren();
}

class FunnyFunny : IClown
{
    public FunnyFunny(string funnyThingIHave)
    {
        this.funnyThingIHave = funnyThingIHave;
    }

    private string funnyThingIHave;
    public string FunnyThingIHave
    {
        get
        {
            return "I got " + funnyThingIHave;
        }
    }

    public void Honk()
    {
        Console.WriteLine(this.FunnyThingIHave);
    }
}

class ScaryScary : FunnyFunny, IScaryClown
{
    public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
    {
        this.numberOfScaryThings = numberOfScaryThings;
    }

    private int numberOfScaryThings;
    public string ScaryThingIHave
    {
        get
        {
            return "Mam " + numberOfScaryThings + " monet";
        }
    }
    public void ScareLittleChildren()
    {
        Console.WriteLine("SLC działa");
    }
}

static void Main(string[] args)
{
    ScaryScary fingersTheClown = new ScaryScary("large", 25);
    FunnyFunny someFunnyClown = fingersTheClown;
    IScaryClown someOtherScaryClown = someOtherScaryClown as ScaryScary;
    someOtherScaryClown.Honk();
    Console.ReadKey();

}
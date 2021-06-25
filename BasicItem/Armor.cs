using System;

class Armor : BasicItem, IBreakable
{
    private float _durability;

    public float Durability
    {
        get => _durability;
        set
        {
            _durability = value;
        }
    }

    public Armor(string name, float durability) : base(name) => Durability = durability;
    public Armor(string name, string description, float durability) : base(name, description) => Durability = durability;

    public bool IsBroken() => Durability == 0;

    public void LoseDurability()
    {
        if (!IsBroken())
            Durability--;
    }

    public void Repair()
    {
        Durability = 100;
    }
}

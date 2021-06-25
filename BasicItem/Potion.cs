using System;

class Potion : BasicItem, IUsable, IStackable
{
    public readonly float Power;
    private int _countOfPotion;

    public int CountOfPotion
    {
        get => _countOfPotion;
        set
        {
            _countOfPotion = value;
        }
    }

    public Potion(string name, float power) : base(name) => Power = power;
    public Potion(string name, string description, float power) : base(name, description) => Power = power;

    public void UseOnSelf(Mob target)
    {
        target.TakeHealing(Power);
        Console.WriteLine("Use healing potion");
    }
    public void UseOnTarget(Weapon weapon)
    {
        weapon.Damage += Power;
    }


    public void Decrease()
    {
        if (CountOfPotion > 0)
            CountOfPotion--;
    }
    public void Increase()
    {
        CountOfPotion++;
    }
}

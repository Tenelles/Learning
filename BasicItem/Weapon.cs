using System;

class Weapon : BasicItem
{
    private float _damage;
    public float Damage
    {
        get => _damage;
        set
        {
            _damage = value;
        }
    }

    public Weapon(string name, float damage) : base(name) => Damage = damage;
    public Weapon(string name, string description, float damage) : base(name, description) => Damage = damage;

}
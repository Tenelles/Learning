using System;

abstract class BasicItem
{
    private float _durability;

    public float Durability => _durability;

    public abstract void Action(Mob target);
}


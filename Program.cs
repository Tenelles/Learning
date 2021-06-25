using System;

class Program
{
    static void Main(string[] args)
    {
        BasicItem[] itemList = { new Weapon(), new Food() };

        Mob slime = new Enemy(100);

        foreach (var item in itemList)
            Use(item, slime);

        MobPositionRandomizer(new Mob[] { slime, new Enemy(10) });


        IKillable target = slime;
        target.Death();
    }

    static void Use(BasicItem item, Mob target)
    {
        item.Action(target);
    }

    static void MobPositionRandomizer(IMovable[] mobs)
    {
        foreach (var mob in mobs)
        {
            mob.MoveTo(new Vector(1, 2));
            // TODO: добавить рандомайзер
        }
    }
}
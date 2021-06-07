using System;
using System.Collections.Generic;
using System.Text;

class Enemy : Mob
{
    public Enemy(int hp) : base(hp)
    {
    }

    public Enemy(int hp, Vector position) : base(hp, position)
    {
    }


}
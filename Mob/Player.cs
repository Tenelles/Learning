using System;

class Player : Mob
{
    // Переменные
    public readonly float Damage; // Сила атаки только для чтения. Изменить можно лишь в конструкторе данного класса или задать значение при инициализации
    public readonly float Armor; // Броня только для чтения. Изменить можно лишь в конструкторе данного класса или задать значение при инициализации

    // Конструктор
    public Player(float hp, float damage, float armor) : base(hp) // добавили силу атаки и броню к конструктору mob'а
    {
        Damage = damage;
        Armor = armor;
    }
    public Player(float hp, Vector position, float damage, float armor) : base(hp, position) // добавили силу атаки и броню к конструктору mob'а, перегрузка конструктора
    {
        Damage = damage;
        Armor = armor;
    }

    public new void TakeDamage(float damage) // Переопределить принятие урона - урон будет снижен с учетом брони
    {
        base.TakeDamage(damage - (Armor * 0.1f));
    }

    public void Attack(Mob mob) // Атаковать указанного моба указанным уроном в случае, если можно атаковать
    {
        mob.TakeDamage(Damage); // Указанный моб получает урон
    }
}

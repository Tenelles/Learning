using System;

class Enemy : Mob
{
    // Переменные
    public readonly float Speed; // Скорость только для чтения. Изменить можно лишь в конструкторе данного класса или задать значение при инициализации

    // Конструктор
    public Enemy(float hp, float speed) : base(hp) => Speed = speed; // добавили скорость к конструктору mob'а
    public Enemy(float hp, Vector position, float speed) : base(hp, position) => Speed = speed; // перегрузка конструктора, добавили скорость к конструктору mob'а

    // Методы

    // Приблизиться к точке (Перемещается на небольшое расстояние по направлению к указанной точке)
    public void Attack(Mob mob, float damage) // Атаковать указанного игрока указанным уроном в случае, если можно атаковать
    {
        if (CanAttack(mob)) // Если можно атаковать указанного моба
        {
            mob.TakeDamage(damage); // Указанный моб получает урон
        }
    }
    public bool CanAttack(Mob mob) => Position == mob.Position; // Если позиция enemy равна позиции mob, то true, иначе false

}
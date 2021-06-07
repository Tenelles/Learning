using System;
using System.Collections.Generic;
using System.Text;

 class Mob
 {  
    // Переменные
    private int _hp;
    private Vector _position;

    // Свойства
    public int HP
    {
        get => _hp;
        private set => _hp = value; // изменение только внутри этого класса, для остальных только чтение.
    }                               // расписано потому, что потом может понадобиться проверка.
    public Vector Position => _position; // read only, только чтение без изменений даже в этом классе.

    // Конструктор
    public Mob(int hp)
    {
        _hp = hp;
        _position = Vector.Zero;
    }
    public Mob(int hp, Vector position) // перегрузка конструктора
    {
        _hp = hp;
        _position = position;
    }

    // Методы
    public void MoveTo(Vector position)
    {
        _position = position; // приватная позиция, т.к. публичная задана только для чтения
    }
    public void TakeDamage(int damage)
    {
        if (damage < 0)
            throw new Exception("damage");
        HP -= damage; // публичное хп, т.к. оно расписано и на чтение, и на изменение. Пользуемся свойством, чтобы добавленные в будущем проверки не опускались.
    }
    public void TakeHealing(int healing)
    {
        if (healing < 0)
            throw new Exception("healing");
        HP += healing; // публичное хп, т.к. оно расписано и на чтение, и на изменение. Пользуемся свойством, чтобы добавленные в будущем проверки не опускались.
    }
}
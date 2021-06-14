using System;

 class Mob
 {  
    // Переменные
    private float _hp;
    protected Vector _position;

    // Свойства
    public float HP
    {
        get => _hp;
        protected set // изменение внутри этого класса и наследниках, для остальных только чтение.
        {
            if (value <= 0)
                throw new Exception("hp");
            _hp = value;
            Console.WriteLine($"Now my HP is {HP}");
            if (HP <= 0)
                Console.WriteLine("I am dead");
        }
    }
    public Vector Position => _position; // read only, только чтение без изменений даже в этом классе.

    // Конструктор
    public Mob(float hp)
    {
        _hp = hp;
        _position = Vector.Zero;
    }
    public Mob(float hp, Vector position) // перегрузка конструктора
    {
        _hp = hp;
        _position = position;
    }

    // Методы
    public void MoveTo(Vector position)
    {
        _position = position; // приватная позиция, т.к. публичная задана только для чтения
    }
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            throw new Exception("damage");
        HP -= damage; // публичное хп, т.к. оно расписано и на чтение, и на изменение. Пользуемся свойством, чтобы добавленные в будущем проверки не опускались.
    }
    public void TakeHealing(float healing)
    {
        if (healing < 0)
            throw new Exception("healing");
        HP += healing; // публичное хп, т.к. оно расписано и на чтение, и на изменение. Пользуемся свойством, чтобы добавленные в будущем проверки не опускались.
    }
}
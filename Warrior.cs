using System;

namespace War
{
    abstract class Warrior
    {
        public int _health { get; set; }
        public int _armor { get; set; }
        public int _damage { get; set; }
        

        public Warrior(Random random)
        {
            _health = random.Next(100, 121);
            _armor = random.Next(20, 31);
            _damage = random.Next(50, 60);
        }

        public virtual bool TakeDamage(int damage)
        {
            _health -= damage - _armor;
            if (_health <= 0)
            {
                return true;
            }
            return false;
        }
    }
}

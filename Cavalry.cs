using System;

namespace War
{
    internal class Cavalry : Warrior
    {
        public Cavalry(Random random) : base(random)
        {
            _armor += 20;
            _health -= 50;
        }

        public override bool TakeDamage(int damage)
        {
            return base.TakeDamage(damage);
        }
    }
}

using System;

namespace War
{
    internal class Archer : Warrior
    {
        public Archer(Random random) : base(random)
        {
            _damage += 20;
            _armor -= 15;
        }

        public override bool TakeDamage(int damage)
        {
            return base.TakeDamage(damage);
        }
    }
}

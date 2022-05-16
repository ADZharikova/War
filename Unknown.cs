using System;

namespace War
{
    internal class Unknown : Warrior
    {
        public Unknown(Random random) : base(random)
        {

        }
        public override bool TakeDamage(int damage)
        {
            return base.TakeDamage(damage);
        }
    }
}

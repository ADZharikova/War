using System;
using System.Collections.Generic;

namespace War
{
    internal class Platoon
    {
        private List<Cavalry> _cavalries = new List<Cavalry>();
        private List<Archer> _archers = new List<Archer>();
        private List<Unknown> _unknowns = new List<Unknown>();
        private bool _isDied;

        public void AddCavalries(int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                _cavalries.Add(new Cavalry(random));
            }
        }

        public void AddArchers(int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                _archers.Add(new Archer(random));
            }
        }

        public void AddUnknowns(int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                _unknowns.Add(new Unknown(random));
            }
        }

        public void ShowInfo()
        {
            foreach (var cavalry in _cavalries)
            {
                Console.WriteLine($"Здоровье война на коне: {cavalry._health}, броня: {cavalry._armor}, урон: {cavalry._damage}");
            }

            foreach (var archer in _archers)
            {
                Console.WriteLine($"Здоровье стрелка: {archer._health}, броня: {archer._armor}, урон: {archer._damage}");
            }

            foreach (var unknown in _unknowns)
            {
                Console.WriteLine($"Здоровье хз кого: {unknown._health}, броня: {unknown._armor}, урон: {unknown._damage}");
            }
        }

        public int BackDamage()
        {
            if (_cavalries.Count != 0)
            {
                return _cavalries[0]._damage;
            }

            else if (_archers.Count != 0 && _cavalries.Count == 0)
            {
                return _archers[0]._damage;
            }

            else if (_archers.Count == 0 && _cavalries.Count == 0 && _unknowns.Count != 0)
            {
                return _unknowns[0]._damage;
            }

            return 0;
        }

        public bool TakeDamage(int damage)
        {
            if (_cavalries.Count != 0)
            {
                _isDied = _cavalries[0].TakeDamage(damage);

                if (_isDied)
                {
                    _cavalries.Remove(_cavalries[0]);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Чувак умер.");
                    Console.ResetColor();
                }
                return true;
            }

            else if (_archers.Count != 0 && _cavalries.Count == 0)
            {
                _isDied = _archers[0].TakeDamage(damage);

                if (_isDied)
                {
                    _archers.Remove(_archers[0]);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Чувак умер.");
                    Console.ResetColor();
                }
                return true;
            }

            else if (_archers.Count == 0 && _cavalries.Count == 0 && _unknowns.Count != 0)
            {
                _isDied = _unknowns[0].TakeDamage(damage);

                if (_isDied)
                {
                    _unknowns.Remove(_unknowns[0]);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Чувак умер.");
                    Console.ResetColor();
                }
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool ShowMassage()
        {
            if (_archers.Count == 0 && _cavalries.Count == 0 && _unknowns.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}

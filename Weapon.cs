using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RpgLogicProject
{
    public class Weapon
    {
        public Creature creature { get; set; }
        private int _hitCount = 0;

        private const double _poisonDamage = 10;

        private double _criticalMultiplier = 1.5;

        public HitProps GetHitProps(double damage)
        {
            double damageValue = damage;
            bool cold=false; 
            _hitCount++;

            if (_hitCount % 3 == 0)
            {
                damageValue *= _criticalMultiplier;
            }
            if (_hitCount % 5 == 0)
            {
                cold = true;
                Console.WriteLine($"{creature.Name} заморозил противника!");
            }
            return new HitProps(damageValue, cold , _poisonDamage  );

        }

    }
}

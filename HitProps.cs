using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLogicProject
{
    public class HitProps
    {

        public double DamageValue { get; set; }

        public bool IsFreezing { get; set; }

        public double PoisonDamageValue { get; set; }

        


        public HitProps(double damageValue, bool isFreezing , double poisonDamage)
        {
            DamageValue = damageValue;
            IsFreezing = isFreezing;
            PoisonDamageValue = poisonDamage;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLogicProject
{
    public class Creature
    {
        //Свойства существа 
        public string Name { get; set; }
        public int Level { get; set; }
        public double Hp { get; set; }

        public virtual double Damage { get;  set; }

        public BackPack Backpack { get; set; }

        //дебаффы

        private double _poisonDamagePerMove = 0;
        public double PoisonDamagePerMove
        {
            get
            {
                return _poisonDamagePerMove;
            }
            set { _poisonDamagePerMove = value;}
        }

        private bool isFreezed = false;
        public bool IsFreezed
        {
            get { return isFreezed; }

            set { isFreezed = value; }

        }

        public Weapon Weapon { get; set; }

        public Creature Target { get; private set; }


        public void SetTarget(Creature creature)
        {

            Target = creature;

        }

        public void Attack()
        {
            if (IsFreezed || Target is null || Target?.Hp <= 0) return;
                    var hitProps = Weapon.GetHitProps(Damage);

            Target.Hp -= hitProps.DamageValue;
            Target.IsFreezed = hitProps.IsFreezing;
            Target.PoisonDamagePerMove = hitProps.PoisonDamageValue;


        }

    }
}

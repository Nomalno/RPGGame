using System;
namespace RpgLogicProject
{
	public class Hero : Creature
	{



        // Добавить оружие или броню с модификаторами:
        // CRIT - каждый 3 удар увеличивает урон на 150%
        // COLD - каждый 5 удар замораживает противника и он пропускает ход
        // POSION - каждый ход наносится дополнительно 10 урона
        // Модификаторы могут меняться в зависимости от вашей фантазии 

        public Hero(string name, int level, double hp)
        {
            Name = name;
            Level = level;
            Hp = hp;
            Damage = 1.1 * Level;
            Backpack = new BackPack(15, 85);
            Weapon = new Weapon();
            Weapon.creature= this;
        }

        public void LootCreature(Creature creature)
        {

            

            for (int i = 0; i < creature.Backpack.ItemsInBackPack.Count; i++)
            {
                if (Backpack.GetWeigth() + creature.Backpack.GetItem(i).Weight > Backpack.MaxWeight) return;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($">Забрал: {creature.Backpack.ItemsInBackPack[i].Name} ");
                Console.ForegroundColor = ConsoleColor.White;
                Backpack.Add(creature.Backpack.ItemsInBackPack[i]);
            }
            Console.WriteLine("Залутано");
            

        }


        
    }
}


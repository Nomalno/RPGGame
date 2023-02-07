using System;
namespace RpgLogicProject
{
    //Класс отвечающий за вещь в рюкзаке
	public class Item
	{
		public string Name { get; set; }
		public int Weight { get; set;}

        public Item()
        {

        }
        public Item(string name, int weigth)
        {
            Name = name;
            Weight = weigth;
        }
    }
}


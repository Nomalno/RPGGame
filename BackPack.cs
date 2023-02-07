using System;
using System.Runtime.CompilerServices;

namespace RpgLogicProject
{

    //Рюкзак
    public class BackPack
    {
        //Массив обьектов в рюкзаке
        public List<Item> items = new List<Item>();

        public List<Item> ItemsInBackPack
        {
            get { return items; }
            set { items = value; }
        }

        //Следующая свободная ячейка
        private int maxCount = 0;

        private int maxWeight;
        public int MaxWeight
        {
            get { return maxWeight; }
            set { maxWeight = value; }

        }

        public BackPack(int maxCount, int maxWeight)
        {
            this.maxWeight = maxWeight;
            this.maxCount = maxCount;
        }

        public void Add(Item item)
        {
            int weight = GetWeigth();
           
            if (maxCount <= items.Count || weight + item.Weight > MaxWeight) return;
           
            
            items.Add(item);

            //Проверить нет ли перевеса (использовать метод GetWeigth())
            //Проверить есть ли свободная ячейка
            //Добавить item в массив по счетчику count
            
        }

        public int GetWeigth()
        {
            int result = 0;
            // Вычислить текуший вес рюкзака\
            
            for (int i = 0; i < items.Count; i++)
            {
                //Console.WriteLine(items[i]);
                result += items[i].Weight;
                
            }
 
            return result;
        }
        public Item GetItem(int index)
        {
            return items[index];
        }


    }
}


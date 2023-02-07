using RpgLogicProject;

//Инициализировать классы. И начать битву 
Console.WriteLine("Битва!");

var elf = new Hero("LEGOLAS", 25, 250);


elf.Backpack.Add(new Item("shield", 1));
elf.Backpack.Add(new Item("sword", 1));
elf.Backpack.Add(new Item("Hood", 5));


var orc = new Enemy("Thrall", 20, 270);



orc.Backpack.Add(new Item("Big Sword", 3));
orc.Backpack.Add(new Item("Armor", 7));

var arena = new BattleArena(orc, elf);


var pobedka = arena.Battle();

if (pobedka == 1) elf.LootCreature(orc);

if (pobedka == 1) Console.WriteLine("Эльф победил");
else Console.WriteLine("Эльф проиграл");
Console.ReadKey();


///////////////////////////////////////////////////////////////////
// Дополнительное задание на 5.
// Реализовать механизм лута предметов с противника в случае победы
///////////////////////////////////////////////////////////////////
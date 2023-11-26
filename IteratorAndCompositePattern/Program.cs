// Menü oluşturma
using IteratorAndCompositePattern;

var mainMenu = new Menu("Ana Menü");
var breakfastMenu = new Menu("Kahvaltı Menüsü");
var lunchMenu = new Menu("Öğle Yemeği Menüsü");

mainMenu.AddComponent(breakfastMenu);
mainMenu.AddComponent(lunchMenu);

breakfastMenu.AddComponent(new MenuItem("Omlet", 7.99));
breakfastMenu.AddComponent(new MenuItem("Sucuklu Yumurta", 6.99));

lunchMenu.AddComponent(new MenuItem("Tavuk Şiş", 12.99));
lunchMenu.AddComponent(new MenuItem("Izgara Levrek", 14.99));

// Menüyü görüntüleme
Console.WriteLine("\nMenüyü görüntüleme:");
mainMenu.Print();

// Iterator kullanarak menüde gezi
Console.WriteLine("\nIterator kullanarak menüde gezinerek Menü Elemanlarını görüntüleme:");
var iterator = new MenuIterator<IMenuComponent>(new List<IMenuComponent> { mainMenu });
while (iterator.HasNext())
{
    iterator.Next().Print();
}

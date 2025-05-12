int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

double priceChickenMenu = chickenMenu * 10.35;
double priceFishMenu = fishMenu * 12.40;
double priceVegetarianMenu = vegetarianMenu * 8.15;

double totalPriceMenu = priceChickenMenu + priceFishMenu + priceVegetarianMenu;
double priceDessert = 0.20 * totalPriceMenu;
double priceDelivery = 2.50;

double totalPriceOrder = totalPriceMenu + priceDessert + priceDelivery;

Console.WriteLine(totalPriceOrder);

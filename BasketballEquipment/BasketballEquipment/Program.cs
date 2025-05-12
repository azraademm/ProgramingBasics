int priceOneYear = int.Parse(Console.ReadLine());

double priceShoe = priceOneYear - priceOneYear * 0.40;
double priceClothes = priceShoe - priceShoe * 0.20;
double priceBall = priceClothes * 0.25;
double priceAccessories = priceBall * 0.20;

double totalPrice = priceOneYear + priceShoe + priceClothes + priceBall + priceAccessories;

Console.WriteLine(totalPrice);

int packPens = int.Parse(Console.ReadLine());
int packMarkers = int.Parse(Console.ReadLine());
int litersOfDetergent = int.Parse(Console.ReadLine());
int percentReduction = int.Parse(Console.ReadLine());

double pricePens = packPens * 5.80;
double priceMarkers = packMarkers * 7.20;
double priceDetergent = litersOfDetergent * 1.20;
double totalPrice = pricePens + priceMarkers + priceDetergent;

double priceWithDiscount = totalPrice - (totalPrice * percentReduction / 100);

Console.WriteLine(priceWithDiscount);
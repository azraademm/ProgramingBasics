int nylonQuantity = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int amountOfThinner = int.Parse(Console.ReadLine());
int hour = int.Parse(Console.ReadLine());

double priceNylon = (nylonQuantity + 2) * 1.50;
double pricePaint = (amountOfPaint * 1.10) * 14.50;
double priceThinner = amountOfThinner * 5.00;
double priceBags = 0.40;

double totalPrice = priceNylon + pricePaint + priceThinner + priceBags;
double priceMaster = (totalPrice * 0.30) * hour;
double finalPrice = totalPrice + priceMaster;

Console.WriteLine(finalPrice);

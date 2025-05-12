int lengthInCm = int.Parse(Console.ReadLine());
int widthInCm = int.Parse(Console.ReadLine());
int heightInCm = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double aquariumVolume = lengthInCm * widthInCm * heightInCm;
double volumeInLiters = aquariumVolume * 0.001;
double spaceOccupied = percentage / 100;
double necessaryLiters = volumeInLiters * (1 - spaceOccupied);

Console.WriteLine(necessaryLiters);

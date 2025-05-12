int bookPages = int.Parse(Console.ReadLine());
int pagesOneHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int totalTimeReading = bookPages / pagesOneHour;
int needTime = totalTimeReading / days;

Console.WriteLine(needTime); 
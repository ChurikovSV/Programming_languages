int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int fNum = num / 100;
int lNum = num % 10;

int result = fNum * 10 + lNum;
Console.WriteLine(result);

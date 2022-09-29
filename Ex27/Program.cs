int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()?? "0");
    return number;
}
void PrintData(string msg, int value)
{
     Console.WriteLine(msg+value);
}
int DigitCount(int num)
{
int res = 0;
while (num>0)
{ 
res = res+num%10;
num = num/10;
}
return res;
}
int DigitCountString(int num)
{
int resstring = 0;
String StringNumber=num.ToString(); 
for (int i = 0; i < StringNumber.Length; i++)
{
resstring += int.Parse(Convert.ToString(StringNumber[i]));
}
return resstring;
}
int num = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
int res = DigitCount(num);
Console.WriteLine(DateTime.Now-d1);
PrintData("Сумма цифр в числе: ", res);

DateTime d2 = DateTime.Now;
int resstring = DigitCountString(num);
Console.WriteLine(DateTime.Now-d2);
PrintData("Сумма цифр в числе: ", resstring);
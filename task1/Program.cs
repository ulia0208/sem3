Console.WriteLine("Введите число");

int n = Convert.ToInt32(Console.ReadLine());

int n1=n/10000;
int n2=n/1000-(n/10000)*10;
int n4=(n%100)/10;
int n5=n%10;

if (9999<n && n<100000)
{
    if(n1==n5 && n2==n4)
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("не Палиндром");
    }
}
else 
{
    Console.WriteLine("Не пятизначное! Нужно пятизначное");
}
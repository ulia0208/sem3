Console.WriteLine("Ведите число");
int num=Convert.ToInt32(Console.ReadLine());
int k=0;
for (int i=0; i<=num; i++)
{
  k = i*i*i; 
  Console.Write($"{k}  " );
}
//return k;

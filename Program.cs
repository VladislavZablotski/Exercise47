Console.WriteLine("Введите число:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [rows,columns];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[i,j]=new Random().NextDouble().;
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}

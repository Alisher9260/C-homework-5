// задайте массив, заполненный случайными положительными трехзначными числами
// Напишите программу которая покажет количество четных чисел в массиве
/*int[] CreateRandomArray(int [] numbers)
{
   
    for (int i =0; i < numbers.Length;i++) 
        numbers[i] = new Random().Next (100,1000);

        return numbers; 
}

void Showarray( int[] array)
{
     for (int i = 0; i < array.Length;i++)
     Console.Write (array [i] + " " );

     Console.WriteLine();
}
Console.WriteLine("задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
CreateRandomArray(numbers);
Showarray(numbers);
 int current =0;
  for (int  i  = 0;  i < numbers.Length;  i ++)
  {
    if(numbers[i] % 2 == 0 )
    current++;
  }
Console.WriteLine ($"всего {numbers.Length} чисел,{current}  - четные числа");*/


//Задайте одномерный массив, заполненный случайными числами.
// Найдите ссумму элементов массива стоящих на нечетных позициях
/*int[] CreateRandomArray(int [] numbers)
{
   
    for (int i =0; i < numbers.Length;i++) 
        numbers[i] = new Random().Next (1,10);

        return numbers; 
}

void Showarray( int[] array)
{
     for (int i = 0; i < array.Length;i++)
     Console.Write (array [i] + " " );

     Console.WriteLine();
}
Console.WriteLine("задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
CreateRandomArray(numbers);
Showarray(numbers);
 int sum =0;
  for (int  i  = 0;  i < numbers.Length;  i +=2)
  {
    sum += numbers[i];
  }
Console.WriteLine ($"всего {numbers.Length} чисел,{sum}  - сумма чисел на нечетных позициях");*/
//Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементами массива.
/*double [] CreateRandomArray(double [] numbers)
{
   
    for (int i =0; i < numbers.Length;i++) 
        numbers[i] = Convert.ToDouble (new Random().Next (100,1000))/100;

        return numbers; 
}

void Showarray( double [] array)
{
     for (int i = 0; i < array.Length;i++)
     Console.Write (array [i] + " " );

     Console.WriteLine();
}
Console.WriteLine("задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double [size];
CreateRandomArray(numbers);
Showarray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;
  for (int  i  = 0;  i < numbers.Length;  i ++)
  {
    if(numbers[i] > max)
    {
      max = numbers[i];
    }
    if(numbers[i] < min)
    {
      min = numbers[i];
    }
    
  }
Console.WriteLine ($"{max} - максимальное значение, {min}  - минимальное");
Console.WriteLine ($" Разница между максимальным и минимальным элементом = {max - min}");*/
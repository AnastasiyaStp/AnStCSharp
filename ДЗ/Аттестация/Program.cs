// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// M = 1; N = 5 -> 1, 2, 3, 4, 5
// M = 4; N = 8 -> 4, 5, 6, 7, 8

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void che(int m, int n)
{
    if (m > n)
    return;
    if (m % 2 == 0);
{
    Console.Write($"{m}, ");
}
che(m+1,n);
}



//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
//  m = 2, n = 3 -> A(m,n) = 29
 
 int AkkermanFunc(int m, int n)
 {
    if(m == 0)
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
       return AkkermanFunc(m - 1, 1); 
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.WriteLine(AkkermanFunc(3,2));



// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void print(int [] A, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(A[n] + " "); 
      	print(A, n - 1); 
      } 
      else Console.WriteLine(A[0]); 
    } 
void Main()   
    { 
      int [] num = {1, 2, 5, 0, 10, 34}; 
      print(num, num.Length - 1); 
    }  

Main();
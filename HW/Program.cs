int InText(string Text)
{
    Console.WriteLine(Text);
    return Convert.ToInt32(Console.ReadLine());
}



void CreatarrayInt(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-100,100);
            
        }
        
    }
}


void Printarray(int[,] array)
{
    
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}\t  ");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Task54()
{
    int n = InText("Введите колличество строк массива");
    int m = InText("Введите колличество строк массива");
    int [,] numbers = new int[n,m];
    CreatarrayInt(numbers);    
    for (int i = 0 ; i <  numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1);j++)
        {
            for (int x = 1;x<numbers.GetLength(1);x++)
                if (numbers[i,x-1] < numbers[i,x])
                {
                        
                    (numbers[i,x],numbers[i,x-1]) =(numbers[i,x-1],numbers[i,x]);
                
                }
        
        }
    }
    Console.WriteLine( );
    Printarray(numbers);

}
void Task56()
{
    int n = InText("Введите колличество строк массива");
    int m = InText("Введите колличество строк массива");
    int [,] numbers = new int[n,m];
    CreatarrayInt(numbers);
    
    int maxsum=-100000;
    int maxini = -1;
    int sum = 0;
    
    for (int i = 0 ; i <  numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1);j++)
        {
            
            sum+=numbers[i,j];
            
        }
        if (sum > maxsum)
        {
            maxsum = sum;
            maxini = i;
        }
        sum = 0;
    }
    Printarray(numbers);
    Console.WriteLine($"{maxini+1} строка массива имеет максимальную сумму элементов" );
    
}
void Task58()
{
    int n = 4;
    int m = 4;
    int [,] numbers = new int[n,m];
    int maxi = n-1;
    int maxj = m-1;
    int mini = 0;
    int minj = 0;
    int i = 0;
    int j = 0;
    int count = 1;
    while(count < n*m)
    {
        while(j < maxj && count < n*m)
        {
            
            numbers[i,j] = count;
            count++;
            j++;
            Printarray(numbers);
        }
        
        while(i < maxi && j==maxj && count < n*m)
        {
            numbers[i,j] = count;
            count++;
            i++;
            Printarray(numbers);
        }
        
        while(j > minj && i==maxi && count < n*m)
        {
            numbers[i,j] = count;
            count++;
            j--;
            Printarray(numbers);
        }
        
        while(i > mini+1 && j ==minj && count < n*m)
        {
            numbers[i,j] = count;
            count++;
            i--;
            Printarray(numbers);
        }
        if (count == n*m)
        {
            numbers[i,j] = count;
        }

        maxi --;
        maxj --;
        
       
    }
    
    
    Printarray(numbers);
        
}
Task54();
Task56();
Task58();
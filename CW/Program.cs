int TextIN()
{
    return new  Random().Next(4,10);
}

void InArray( int[] array )
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }

}
void PrArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
        
    }
}

void Task40()
{
    int size = TextIN();
    int [] numbers = new int[size];
    InArray(numbers);
    PrArray(numbers);
    int MaxIn = numbers.Length - 1;
    for(int i =0;i < numbers.Length/2;i++)
    {
        
        (numbers[i],numbers[MaxIn-i]) = (numbers[MaxIn-i], numbers[i]);
    }
    Console.WriteLine();
    PrArray(numbers);

}
void Task41()
{
    int a = TextIN();
    int b = TextIN();
    int c = TextIN();
    if(a+b>c && a+c>b && c+b>a)
    {
        Console.WriteLine("True");       
    }
    else Console.WriteLine("false");  


}
void Task()
{
    
    int size = TextIN();
    int [] numbers = new int [size];
    InArray(numbers);
    PrArray(numbers);
    

    for(int i = 0;i < size;i++)
    {
        for(int n = 1;n < size;n++)
        {   if (numbers[n] > numbers[n-1])
            {
                
                (numbers[n],numbers[n-1]) =(numbers[n-1],numbers[n]);

            }
        }
    }
    Console.WriteLine();
    PrArray(numbers);
}
//Task40();
Task();
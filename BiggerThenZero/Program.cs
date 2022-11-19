/*Пользователь вводит с клавиатуры M чисел. 
Added a program that counts how many numbers greater than 0 the user has entered.*/

int BiggerThenZero(int size)
{
    int [] array = new int [size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Numbers bigger then zero in array is: {BiggerThenZero(size)}");

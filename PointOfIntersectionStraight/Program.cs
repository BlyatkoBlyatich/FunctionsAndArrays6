/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

 void IntersectOrParallel (double k1, double k2, double b1, double b2)
 {
    if(k1==k2 && b1 != b2)
    {
        Console.WriteLine("Straight is parallel");
        
    }    
    else if (k1==k2 && b1 == b2)
    {
        Console.WriteLine("Straight is equal");
      
    }
    else         
    {
        double[] array = new double [2];
        array[0] = (b2 - b1) / (k1 - k2);
        array[1] = k2*array[0] + b2;
        
        Console.WriteLine("The straight is intersection in coords: ");
        Console.Write(Math.Round(array[0], 2) + " and  " + Math.Round(array[1]), 2);    
    }    
 }

Console.WriteLine("Inpur coord k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inpur coord k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inpur coord b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inpur coord b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());


IntersectOrParallel(k1, k2, b1, b2);



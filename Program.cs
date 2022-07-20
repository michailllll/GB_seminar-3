// программа выводит кубы чисел от 1 до N


 
// Console.WriteLine("Введите положительное число");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[N];
// for(int i = 0; i < N; i++)
// {
//     arr[i]=i+1;
// }

// void Squre(int[] array){
// {
    
//     for(int i = 0; i<N; i++)
//     {
//        int temp = arr[i];
//        arr[i] = temp*temp*temp;
//     }
    
// }
// Console.WriteLine(string.Join("," ,arr));
// }

// Squre(arr);


// программа, которая проверяет число на палиндром

// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number/10000 == 0 || (number/10000)> 10)
// {
//     Console.WriteLine("Число не пятизначное");
// }
// else    
//     {int first = number/1000;
//     int second = ((number % 10) * 10) + ((number % 100)/10);

//     if(first == second)
//     {
//         Console.WriteLine("Число палиндром");
//     }
//     else
//     {
//         Console.WriteLine("Число не палиндром");
//     }
//     }

// программа находит расстаяние между двумя точками в пространстве

Console.WriteLine("Координиту X точки A");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координиту Y точки A");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координиту Z точки A");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координиту X точки B");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координиту Y точки B");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координиту Z точки B");
int Bz = Convert.ToInt32(Console.ReadLine());

double X = (Ax + Bx)*(Ax + Bx);
double Y = (Ay + By)*(Ay + By);
double Z = (Az + Bz)*(Az + Bz);

double distance = Math.Sqrt(X + Y +Z);

Console.WriteLine(distance);


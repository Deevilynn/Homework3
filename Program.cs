// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// void Pal(int a)
// {
//     int b,c,e,f;
//     b=a/10000;
//     c=(a%10000)/1000;
//     e=(a%100)/10;
//     f=(a%10);
//     if (b == f && c == e) {
//         Console.WriteLine("Число является палиндромом");
//     }
//     else
//     Console.WriteLine("Число не является палиндромом");
// }
// Console.WriteLine("Введите пятизначное число");
// int a=Convert.ToInt32(Console.ReadLine());
// Pal(a);

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// double Ras(int x1, int y1, int z1, int x2, int y2, int z2 )
// {
//     double r = Math.Sqrt( Math.Pow (x2-x1, 2) + Math.Pow (y2-y1,2) + Math.Pow (z2-z1,2));
//     return r;
// }
// Console.WriteLine("Введите координаты первой точки в пространстве");
// Console.WriteLine("x1");
// int x1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("y1");
// int y1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("z1");
// int z1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки в пространстве");
// Console.WriteLine("x2");
// int x2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("y2");
// int y2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("z2");
// int z2=Convert.ToInt32(Console.ReadLine());
// double res=Ras(x1, y1, z1, x2,  y2, z2);
// Console.WriteLine("Расстрояние между двумя точками в пространстве равно: "+res);

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Pow (int a){
//     for (int i = 1;i <= a;i++)
//     {
//         Console.WriteLine($"{i}^{3}={Math.Pow(i,3)}");
//     }
// }
// Console.WriteLine("Введите число");
// int a=Convert.ToInt32(Console.ReadLine());
// Pow(a);

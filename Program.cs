//Принимает номер четверти, выдает знаки x и y.

/*void ShowDiapozon(int quad)
{
  if(quad == 1) Console.WriteLine("x>0,y>0");
  else if(quad == 2) Console.WriteLine("x<0,y>0");
  else if(quad == 3) Console.WriteLine("x<0,y>0");
  else if(quad == 4) Console.WriteLine("x>0,y<0");
  else Console.WriteLine("Incorrect Input");
}

Console.WriteLine("Input number");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowDiapozon(quadrant);
*/

//Task1. Принимает на вход знаки x и y, выдает номер четверти.

/*
int ShowSign(int x, int y)
{ int quad = 0;
  if(x>0 & y>0) quad = 1;
  else if(x<0 & y>0) quad = 2;
  else if(x<0 & y<0) quad = 3;
  else if(x>0 & y<0) quad = 4;
  return(quad);
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 & y == 0) Console.WriteLine("x and y must be positive or negative");
else Console.WriteLine($"Quadrant is {ShowSign(x,y)}");
*/

//Task2. Принимает на вход координаты двух точек, выдает расстояние между ними.


double Distance(double x1, double y1, double x2, double y2)
{
  double X = x1 - x2;
  double Y = y1 - y2;
  return Math.Sqrt(X*X + Y*Y);
}

Console.Write("Input first x: ");
double firstX = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first y: ");
double firstY = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second x: ");
double secondX = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second y: ");
double secondY = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between points is {Math.Round(Distance(firstX, firstY, secondX, secondY),2)}");


//Task3. Принимает N, выдает таблицу квадратов от 0 до N.
/*

void FindSquare(int N)
{
  int count = 1;
  while (count <= N)
  {
    Console.WriteLine(count+" "+count*count);
    count++;
  }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>0) FindSquare(number);
else Console.Write("Number must be positive");
*/

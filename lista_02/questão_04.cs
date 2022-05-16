using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a Base e a altura do retângulo:");
      double Base = double.Parse(Console.ReadLine());
      double altura = double.Parse(Console.ReadLine());
      double area = Base * altura;
      double perimetro = ((Base * 2) + (altura * 2));
      double diagonal = Math.Sqrt((Base * Base) + (altura * altura));
      Console.Write($"Área = {area:0.00}");
      Console.Write(" - ");
      Console.Write($"Perímetro = {perimetro:0.00}");
      Console.Write(" - ");
      Console.Write($"Diagonal = {diagonal:0.00}");
  }
}
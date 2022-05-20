using System;
  class Program {
  public static void Main (string[] args) {
    double A = double.Parse(Console.ReadLine());
    double B = double.Parse(Console.ReadLine());
    double nota1 = A * 3.5;
    double nota2 = B * 7.5;
    double media = (nota1 + nota2) / (3.5 + 7.5);
    Console.WriteLine($"MEDIA = {media:0.00000}");
  }
}
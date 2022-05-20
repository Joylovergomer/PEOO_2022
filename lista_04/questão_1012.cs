using System;
  class Program {
  public static void Main (string[] args) {
    string[] entrada = Console.ReadLine().Split(' ');
    double A = double.Parse(entrada[0]);
    double B = double.Parse(entrada[1]);
    double C = double.Parse(entrada[2]);
    double triangulo = (A * C) / 2;
    double circulo = (3.14159 * (C * C));
    double trapezio = ((A + B) * C) / 2;
    double quadrado = B * B;
    double retangulo = A * B;
    Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
    Console.WriteLine($"CIRCULO: {circulo:0.000}");
    Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
    Console.WriteLine($"QUADRADO: {quadrado:0.000}");
    Console.WriteLine($"RETANGULO: {retangulo:0.000}");
  }
}
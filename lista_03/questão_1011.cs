using System;
  class Program {
  public static void Main (string[] args) {
    double R = double.Parse(Console.ReadLine());
    double pi = 3.14159;
    double volume = (4.0 * pi * (R * R * R) / 3);
    Console.WriteLine($"VOLUME = {volume:0.000}");
  }
}
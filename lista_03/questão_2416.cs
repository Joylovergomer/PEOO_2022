using System;
  class Program {
  public static void Main (string[] args) {
    string[] entrada = Console.ReadLine().Split(' ');
    int C = int.Parse(entrada[0]);
    int N = int.Parse(entrada[1]);
    int final = C % N ;
    Console.WriteLine($"{final}");
  }
}
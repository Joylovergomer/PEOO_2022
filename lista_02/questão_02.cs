using System;
  class program {
    public static void Main() {
      Console.WriteLine("Digite seu nome completo: ");
      string s = Console.ReadLine();
      string[] nome = s.Split(' ');
      Console.WriteLine($"Bem-vindo ao C#, {nome}");
  }
}
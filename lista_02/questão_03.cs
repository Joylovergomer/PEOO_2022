using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina: ");
    int nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int nota2 = int.Parse(Console.ReadLine());
    int media = ((nota1 * 2) + (nota2 *3)) / (2+3);
    Console.WriteLine("Média Parcial:" + media);
  }
}
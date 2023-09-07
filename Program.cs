using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("Type your name: ");
    var name = Console.ReadLine();
    var array = new char[name.Length];

    for (int i = array.Length; i > 0; i--) {
      array[array.Length - i] = name[i - 1];
      }
    var reversed = new string(array);
    Console.WriteLine("Your name spelled backwards is: " + reversed.ToLower());
    }
      
  }


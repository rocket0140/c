using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine("Hello World");
    
    string name = "outer";
    
    Console.WriteLine(name);

    static void myCall()
    {
      Console.WriteLine("I got called");
    }

    myCall();
    
  }
}

using System;
class Lucas {
  static void Main() {
    int num1 = 10;
    int num2 = 10;
    
    num1 = num1<<1;
    num2 = num2>>1;
    Console.WriteLine("Saida 1: "+num1);//dobra *2
    Console.WriteLine("Saida 2: "+num2);//retira a metade /2
  }
}

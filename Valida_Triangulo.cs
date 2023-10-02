/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Calcular {
    
    public static float lado1;
    public static float lado2;
    public static float lado3;
    
    static void Main() {
        valida1();
        valida2();
        valida3();
        ClassificaTriangulo();
    }
  
  static void valida1() {
      
       try {
                Console.WriteLine("Por favor digite o primeiro lado: ");
                lado1 = float.Parse(Console.ReadLine());
            }
            
        catch (FormatException) {
            Console.WriteLine("Digite um valor valido, por favor.");
            valida1();
            return;
        }
        
  }
  
    static void valida2() {
       try {
                Console.WriteLine("Por favor digite o segundo lado: ");
                lado2 = float.Parse(Console.ReadLine());
            }
            
        catch (FormatException) {
            Console.WriteLine("Digite um valor valido, por favor.");
            valida2();
            return;
        }
  }
  
   static void valida3() {
       try {
                Console.WriteLine("Por favor digite o terceiro lado: ");
                lado3 = float.Parse(Console.ReadLine());
            }
            
        catch (FormatException) {
            Console.WriteLine("Digite um valor valido, por favor.");
            valida3();
            return;
        }
  }
  
  static void ClassificaTriangulo() {
      
        if (lado1 == lado2) {
            if (lado2 == lado3) {
                Console.WriteLine("Triangulo Equilatero");
            } else {
                Console.WriteLine("Triangulo Isoceles");
            }
        } else if (lado1 == lado3) {
            Console.WriteLine("Triangulo Isoceles");
        } else if (lado2 == lado3) {
            Console.WriteLine("Triangulo Isoceles");
        } else {
            Console.WriteLine("Triangulo Escaleno");
        }

  }
}


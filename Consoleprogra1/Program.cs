using System;
public class Aprendiendo

{
	public static void Main()
	{
		//Ejercicio 1 edad
		byte ed;
		Console.WriteLine("cuantos años tienes:");
		ed = Convert.ToByte(Console.ReadLine());
		Console.WriteLine($"no aparentas {ed} años "); ;

		//Ejercicio 2 multiplicación
		byte n1, n2;
		Console.WriteLine("Ingrese 2 numeros de 2 crifas:");
		n1 = Convert.ToByte(Console.ReadLine());
		n2 = Convert.ToByte(Console.ReadLine());
		ushort b3 = Convert.ToUInt16(n1 * n2);
		Console.WriteLine(b3);

		//Ejercicio 3 
		long num1, num2, rest, sum, prod;
		Console.WriteLine("Ingrese el primer número: ");
		num1 = Convert.ToInt64(Console.ReadLine());
		Console.WriteLine("Ingrese el segundo número: ");
		num2 = Convert.ToInt64(Console.ReadLine());
		sum = num1 + num2;
		Console.WriteLine("El resultado de la suma es: " + sum);
		Console.ReadLine();


		rest = num1 - num2;//operacion resta
		Console.WriteLine("El resultado de la resta es: " + rest);
		Console.ReadLine();

		prod = num1 / num2;
		Console.WriteLine("El resultado del producto  es: " + prod);
		Console.ReadLine();


	}
}








// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;

int b;
 a = 10;
 b = a;

 Console.WriteLine("valor de a:"+a);

 Console.WriteLine("valor de b:"+b);


int numIngresado;
bool valido;

valido = false;

 do
 {
    Console.WriteLine("Ingrese un numero");
valido = false;
string cadena = Console.ReadLine();
valido = int.TryParse(cadena, out numIngresado);

if (!valido || numIngresado < 0)
{
    Console.WriteLine("El numero ingresado no es valido");
}

    
 } while (!valido || numIngresado < 0);

int aux, resto;

while (numIngresado >= 10)
{
    resto = numIngresado % 10;
    numIngresado = numIngresado / 10;
    Console.Write(resto);
}
Console.Write(numIngresado);
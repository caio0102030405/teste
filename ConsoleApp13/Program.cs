int[] numero = new int[5];
int resultado = 0;
for(int contador = 0; contador <5; contador+=1)
{
    Console.WriteLine("diga um numero.");
    numero[contador] = int.Parse(Console.ReadLine());
}
resultado = numero[0] + numero[1] + numero[2] + numero[3] + numero[4];

Console.WriteLine(resultado);
Console.WriteLine("OLá Mundo ");
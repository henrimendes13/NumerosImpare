/*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, 
 * um valor por linha, inclusive o X, se for o caso.*/

int x;

x=int.Parse(Console.ReadLine());

for(int i=1; i<=x; i=i+2)
{
    int impares = 0 + i;
    Console.WriteLine(impares);
}
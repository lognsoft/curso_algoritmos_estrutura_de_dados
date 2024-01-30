int contadorDeMovimentos = 0;

int numeroDeDiscos = 10;
TorreDeHanoi(numeroDeDiscos, 'A', 'C', 'B');
Console.WriteLine("Número total de movimentos: " + contadorDeMovimentos);

void TorreDeHanoi(int n, char origem, char destino, char auxiliar)
{
  if (n == 1)
  {
   Console.WriteLine($"Mover disco 1 de {origem} para {destino}");
   contadoDeMovimentos++;
   return;
  }
    
  TorreDeHanoi(n - 1, origem, auxiliar, destino);
  Console.WriteLine($"Mover disco {n} de {origem} para {destino}");
  contadorDeMovimentos++;
  TorreDeHanoi(n - 1, auxiliar, destino, origem);
}
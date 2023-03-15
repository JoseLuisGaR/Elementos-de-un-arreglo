using System;

class Program
{
    static void Main(string[] args)
    {
        // En la linea 12 se indica el tipo de dato el cual sera el arreglo
        //Tambien se le da un nombre en esta misma linea 
        // Se indica su longitud y se le da memoria
        // Se crea el arrelgo con datos que tendra ya definidos

        int[] numeros = new int[5] { 10, 15, 7, 20, 5 };

        // Imprime cada elemento del arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Elemento {0}: {1}", i, numeros[i]);
        }

        // Encuentra el valor máximo y mínimo del arreglo
        int maximo = numeros[0];
        int minimo = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maximo)
            {
                maximo = numeros[i];
            }
            if (numeros[i] < minimo)
            {
                minimo = numeros[i];
            }
        }

        // Imprime el valor máximo y mínimo del arreglo
        Console.WriteLine("Valor máximo: {0}", maximo);
        Console.WriteLine("Valor mínimo: {0}", minimo);

        // Suma todos los valores del arreglo
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        // Imprime la suma de los valores del arreglo
        Console.WriteLine("Suma de los valores: {0}", suma);

        Console.ReadKey();
    }
}

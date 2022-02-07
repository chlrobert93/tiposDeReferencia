using System;

class Puntero
{
    public int X, Y;
}


namespace tiposDeReferencia
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Un tipo de referencia tiene dos prtes: un objecto y su referencia
            //El contenido de una variable de tipo de referecnia es la referecnia

            Puntero p1 = new Puntero();

            p1.X = 1;

            //Copia la referencia a p1

            Puntero p2 = p1;

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);

            //Cambia p1.X;  

            p1.X = 2;

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);

            Console.ReadKey();

            /*Al asignar una variable de tipo de referencia a otra variable, se copia la referencia, no el objeto en sí. Es como realizar una copia de una llave. Puede usar múltiples variables para referirse al mismo objeto, de igual manera que puedes tener varias llaves de tu habitación.*/

        }
    }
}

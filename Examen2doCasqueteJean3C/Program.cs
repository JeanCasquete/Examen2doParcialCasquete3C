using System;

namespace Examen2doCasqueteJean3C
{
    class Program
    {
        static void Main(string[] args)
        {
            //En el primero ira el mensaje que mostrara el nombre del restaurante,
            //Utilizando asi la la propiedad Instance, el constructor y la variable
            Console.WriteLine(PatronSingleton.Instance.mensajito);

            // Aqui hacemos uso de la propiedad INSTANCE para mostrar un segundo mensaje y como podemos ver usamos la misma propiedad
            PatronSingleton.Instance.mensajito = "Nos encuentra en la calle 504 avenida 503";
            Console.WriteLine(PatronSingleton.Instance.mensajito);

            // Aquí mostramos el 3er mensaje utilizando como los anterior usaremos la propiedad INSTANCE
            PatronSingleton.Instance.mensajito = "        Atendemos de 8AM A 18PM   ";
            Console.WriteLine(PatronSingleton.Instance.mensajito);

            // Aquí mostramos el 4to mensaje utilizando como los anteriores usaremos la propiedad INSTANCE 
            PatronSingleton.Instance.mensajito = "    ¡VISITENOS!   ";
            Console.WriteLine(PatronSingleton.Instance.mensajito);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nombre: Casquete Rodriguez Jean Pier 3C
// Aqui uso el patron de diseño Singleton para mostrar los datos de un restaurante en los folletos del menu
namespace ConsoleApp1
{
    public class PatronSingleton
    {
        //Privatisamos la clase Singleton con su atributo instance
        private static PatronSingleton instance = null;

        //Creamos mensaje para mostrar un mensaje en pantalla
        //en esta caso los datos de la plantilla
        //Por el momento este no contiene nada
  
        public string mensajito = "";

        //Creamos el constructor PatronSingleton
        protected PatronSingleton()  
        {
            mensajito = "     Restaurente Delicias del marisco"; //Aqui es donde va a mostrar el primer mensaje que se encuentra en PROGRAM.CS
        }

        public static PatronSingleton Instance //El beneficio de que utilicemos la propiedad INSTANCE de SINGLETON es que siempre será la misma
        {                                // y por ende va ser el mismo para todo, pero aún así no es recomendable utilizarlo para todo.
            get //Utilizamos el get para devolver a la clase instanciada 
            {
                if (instance == null)
                    instance = new PatronSingleton();

                return instance; //Aqui devolvemos lo que contiene la propiedad INSTANCE
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsolsa
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GrupoUsuarios grupo1 = new GrupoUsuarios();
                
                bool retorno;
                int size;

                retorno = grupo1.isEmpty();
                size = grupo1.size();

                Console.WriteLine(retorno);
                Console.WriteLine(size);



                String nombre="", puesto="", id="";
                grupo1.add(0, new Usuario(nombre,puesto,id));

                Console.WriteLine(grupo1.isEmpty());
                Console.WriteLine(grupo1.size());
                grupo1.mostrarUsuarios();

                Console.ReadKey();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);

                Console.ReadKey();
            }
        }
    }
}

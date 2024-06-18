using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos.Services
{
    public class MensageriaSMS
    {

        public bool EnviarMensagem(string texto)
        {
            Console.WriteLine("Enviando o SMS: " + texto);
            return true;
        }

    }
}
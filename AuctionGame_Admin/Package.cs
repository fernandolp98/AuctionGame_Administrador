using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame_Admin
{
    public class Package
    {
        public string Comando { get; set; }
        public string Contenido { get; set; }

        public Package()
        {

        }
        public Package(string comando, string contenido)
        {
            Comando = comando;
            Contenido = contenido;
        }
        public Package(string datos) //Ej: comanto: contenido
        {
            var sepIndex = datos.IndexOf(":", StringComparison.Ordinal);
            Comando = datos.Substring(0, sepIndex);
            Contenido = datos.Substring(Comando.Length);
        }
        public string Serializar()
        {
            return $"{Comando}:{Contenido}";
        }
        public static implicit operator string(Package package)
        {
            return package.Serializar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celularesDiseno
{
    class configColor : ConfigCel
    {
        private celular Cel;
        private string Colores;
        public configColor ( string color)
        {
           
            this.Colores = color;
        }

        public override float costo()
        {
            return  50;
        }

        public  string Color()
        {
            return this.Colores;
        }

        public override string descripcion()
        {
            return this.Color();
        }
    }
}

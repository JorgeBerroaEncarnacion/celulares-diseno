using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celularesDiseno
{
     class camara : ConfigCel
    {
        private celular Cel;
        private camara Cam;
        public camara(celular cel) 
        {
            this.Cel = cel;
        }

        public  void capturar() { }

        

        public override float costo()
        {
            return  30;
        }

        public override string descripcion()
        {
            return this.Cel.descripcion() + ",camara regular";
        }
    }
}

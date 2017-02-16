using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celularesDiseno
{
    class celularBasico : celular
    {
        private celular Cel;
        private camara5MP Cam;

        public  string Color()
        {
            return "gris";
        }

        public celularBasico()

        {

        }
      

        public override float costo()
        {
            return this.Cam.costo() + 400;
        }

        public override string descripcion()
        {
            return this.Color();
        }
    }
}

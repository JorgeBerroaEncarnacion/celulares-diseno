using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celularesDiseno
{
    class PersonalCel : celular
    {
        private configColor Color;
        private camara Cam;
        private celular Cel;

        public PersonalCel(configColor color, camara cam)
        {
            this.Color = color;
            this.Cam = cam;
           
        }

        public override float costo()
        {
            return this.Color.costo() + this.Cam.costo() + 400;
        }

        public override string descripcion()
        {
            return this.Color.descripcion();

        }
    }
}
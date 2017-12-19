using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Datos
    {
        public int casado            { get; set; }
        public int viudo             { get; set; }
        public int soltero           { get; set; }
        public int si_uni            { get; set; }
        public int no_uni            { get; set; }
        public int si_veh            { get; set; }
        public int no_veh            { get; set; }
        public int empleado          { get; set; }
        public int desempleado       { get; set; }
        public int empresario        { get; set; }
        public double probabilidad  { get; set; }
        public double tam           { get; set; }
        public double prob_casado   { get; set; }
        public double prob_desemp    { get; set; }
        public double prob_viudo    { get; set; }
        public double prob_empl     { get; set; }
        public double prob_empr     { get; set; }
        public double prob_nouni    { get; set; }
        public double prob_siuni     { get; set; }
        public double prob_siveh    { get; set; }
        public double prob_noveh    { get; set; }
        public double prob_solt     { get; set; }

        public Datos()
        {
            this.casado = 0;
            this.desempleado = 0;
            this.viudo = 0;
            this.empleado = 0;
            this.empresario = 0;
            this.no_uni = 0;
            this.si_uni = 0;
            this.si_veh = 0;
            this.no_veh = 0;
            this.soltero = 0;
            this.tam = 0;
        }
    }
}

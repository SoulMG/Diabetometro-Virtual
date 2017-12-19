using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Paciente
    {
        public int id { get; set; }
        public double   bajo         { get; set; }   
        public double   normal       { get; set; }   
        public double   sobrepeso    { get; set; }   
        public double   obesidad     { get; set; }   
        public double   fisicabaja   { get; set; }   
        public double   fisicamedia  { get; set; }   
        public double   fisicaalta   { get; set; }   
        public double   mamadia      { get; set; }   
        public double   papadia      { get; set; }   
        public double   abuelapater { get; set; }    
        public double   abuelamater { get; set; }    
        public double   abuelopater { get; set; }    
        public double   abuelomater  { get; set; }   
        public double   sexo        { get; set; }    
        public double   glucemia    { get; set; }
        public double   propens     { get; set; }

        public double   Prob_bajo { get; set; }
        public double   Prob_normal { get; set; }
        public double   Prob_sobrepeso { get; set; }
        public double   Prob_obesidad { get; set; }
        public double   Prob_fisicabaja { get; set; }
        public double   Prob_fisicamedia { get; set; }
        public double   Prob_fisicaalta { get; set; }
        public double   Prob_mamadia { get; set; }
        public double   Prob_papadia { get; set; }
        public double   Prob_abuelapater { get; set; }
        public double   Prob_abuelamater { get; set; }
        public double   Prob_abuelopater { get; set; }
        public double   Prob_abuelomater { get; set; }
        public double   Prob_sexo { get; set; }
        public double   Prob_glucemia { get; set; }
        public double   Prob_propens { get; set; }


        public Paciente()
{
            this.bajo = 0;
       this.Prob_bajo=0;
       this.Prob_normal=0;
       this.Prob_sobrepeso=0;
       this.Prob_obesidad=0;
       this.Prob_fisicabaja=0;
       this.Prob_fisicamedia=0;
       this.Prob_fisicaalta=0;
       this.Prob_mamadia=0;
       this.Prob_papadia=0;
       this.Prob_abuelapater=0;
       this.Prob_abuelamater=0;
       this.Prob_abuelopater=0;
       this.Prob_abuelomater=0;
       this.Prob_sexo=0;
       this.Prob_glucemia=0;
       this.Prob_propens= 0;

            
}


    }


}

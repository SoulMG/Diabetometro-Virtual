using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

     


        }

        private void button1_Click(object sender, EventArgs e)
        {


            Paciente nuevo = new Paciente();

            switch(CB_IMC.Text) {
                case "IMC Menor a 18.5":
                    nuevo.bajo = 1;
                    nuevo.normal = 0;
                    nuevo.sobrepeso = 0;
                    nuevo.obesidad = 0;
                    break;

                case "IMC Mayor o igual  a 18.5 Y Menor o igual a 24.9":
                    nuevo.bajo = 0;
                    nuevo.normal = 1;
                    nuevo.sobrepeso = 0;
                    nuevo.obesidad = 0;
                    break;
                case "IMC Mayor o igual  a 25 Y Menor o igual a 29.9":
                    nuevo.bajo = 0;
                    nuevo.normal = 0;
                    nuevo.sobrepeso = 1;
                    nuevo.obesidad = 0;
                    break;

                case "IMC Mayor a 30":
                    nuevo.bajo = 0;
                    nuevo.normal = 0;
                    nuevo.sobrepeso = 0;
                    nuevo.obesidad = 1;

                    break;

            }
          
            switch (CB_ActFisica.Text) {

                case "Actividad Física Baja":

                    nuevo.fisicabaja = 1;
                    nuevo.fisicamedia = 0;
                    nuevo.fisicaalta = 0;

                    break;


                case "Actividad Física Media":
                    nuevo.fisicabaja = 0;
                    nuevo.fisicamedia = 1;
                    nuevo.fisicaalta = 0;
                    break;


                case "Actividad Física Alta":
                    nuevo.fisicabaja = 0;
                    nuevo.fisicamedia = 0;
                    nuevo.fisicaalta = 1;
                    break;

            }

            if (CB_Sexo.Text == "Masculino")
            {

                nuevo.sexo = 1;
            }
            else {
                nuevo.sexo = 0;
            }

            if (CHB_MaDiab.Checked == true)
            {
                nuevo.mamadia = 1;


            }
            else {
                nuevo.mamadia = 0;
            }

            if (CHB_PaDiab.Checked == true)
            {
                nuevo.papadia = 1;


            }
            else
            {
                nuevo.papadia = 0;
            }

            if (CHB_AbuelaMaDiab.Checked == true)
            {
                nuevo.abuelamater = 1;


            }
            else
            {
                nuevo.abuelamater = 0;
            }

            
            if (CHB_AbueloMaDiab.Checked== true)
            {
                nuevo.abuelomater=1;


            }
            else {
                nuevo.abuelomater = 0 ;
            }

            if (CHB_AbuelaPaDiab.Checked == true)
            {
                nuevo.abuelapater = 1;


            }
            else
            {
                nuevo.abuelapater = 0;
            }


            if (CHB_AbueloPaDiab.Checked == true)
            {
                nuevo.abuelopater = 1;


            }
            else
            {
                nuevo.abuelopater = 0;
            }



            if (Convert.ToDouble(TB_Azucar.Text) >= 100)
            {


                nuevo.glucemia = 1;

            }
            else {

                nuevo.glucemia = 0;
            }






            
            Paciente viejosi = new Paciente();
            Paciente viejono = new Paciente();
            viejosi = OperacionesPaciente.Contar(1);
            viejono = OperacionesPaciente.Contar(0);


            double total = viejosi.bajo + viejosi.normal + viejosi.sobrepeso + viejosi.obesidad + viejono.bajo + viejono.normal + viejono.sobrepeso + viejono.obesidad;
            double ProbabilidadGeneralSi = (viejosi.bajo + viejosi.normal + viejosi.sobrepeso + viejosi.obesidad) / total;

            double cant = viejosi.bajo + viejosi.normal + viejosi.sobrepeso + viejosi.obesidad+ viejono.bajo + viejono.normal + viejono.sobrepeso + viejono.obesidad;

           


            double ProbabilidadGeneralNo = 1 - ProbabilidadGeneralSi;



                        OperacionesPaciente.Comprobar(viejosi);
            OperacionesPaciente.Comprobar(viejono);


           
            OperacionesPaciente.CalcularProbas(viejosi);
            OperacionesPaciente.CalcularProbas(viejono);

           
    
            
            OperacionesPaciente.VerificarDiabetes(nuevo, viejosi, viejono, ProbabilidadGeneralSi, ProbabilidadGeneralNo);

            MessageBox.Show("El resultado del Diabetómetro es de: " + nuevo.propens);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RB_PaDiab_CheckedChanged(object sender, EventArgs e)
        {

        }
      

        private void RB_AbuelaPaDiab_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BDConexion.ObtenerConexion();
            MessageBox.Show("Conexión exitosa");
        }
    }
}

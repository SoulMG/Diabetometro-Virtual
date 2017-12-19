using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class OperacionesPaciente
    {

        public static Paciente Contar(int i)
        {
            BDConexion con = new BDConexion();
            Paciente nuevo = new Paciente();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT count(*) from  paciente where propenso='{0}' and bajo=1 ", i), BDConexion.ObtenerConexion());
            MySqlDataReader reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.bajo = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
          "SELECT count(*) from  paciente where propenso='{0}' and normal =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.normal = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
         "SELECT count(*) from  paciente where propenso='{0}' and sobrepeso =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.sobrepeso = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
            "SELECT count(*) from  paciente where propenso='{0}' and obesidad =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.obesidad = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
          "SELECT count(*) from  paciente where propenso='{0}' and fisicabaja =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.fisicabaja = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
          "SELECT count(*) from  paciente where propenso='{0}' and fisicamedia =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.fisicamedia = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
          "SELECT count(*) from  paciente where propenso='{0}' and fisicaalta =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.fisicaalta = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
       "SELECT count(*) from  paciente where propenso='{0}' and mamadia =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.mamadia = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
"SELECT count(*) from  paciente where propenso='{0}' and papadia =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.papadia = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
"SELECT count(*) from  paciente where propenso='{0}' and abuelapater =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.abuelapater = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
"SELECT count(*) from  paciente where propenso='{0}' and abuelamater =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.abuelamater = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
"SELECT count(*) from  paciente where propenso='{0}' and abuelopater =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.abuelopater = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
"SELECT count(*) from  paciente where propenso='{0}' and abuelomater =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.abuelomater = reader.GetInt32(0);

            };
            reader.Close();

            _comando = new MySqlCommand(String.Format(
"SELECT count(*) from  paciente where propenso='{0}' and sexo =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.sexo = reader.GetInt32(0);

            };
            reader.Close();
            _comando = new MySqlCommand(String.Format(
"SELECT count(*) from  paciente where propenso='{0}' and glucemia =1 ", i), BDConexion.ObtenerConexion());
            reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                nuevo.glucemia = reader.GetInt32(0);

            };

            reader.Close();

            return nuevo;

        }

        public static void Comprobar(Paciente pac)
        {

            // En esta seccion se valida que almenos alguna de las frecuencias tenga un 0 y si es asi se le aumento +1 a todas las frecuencias
            if (pac.bajo == 0 ||
                  pac.normal == 0 ||
                  pac.sobrepeso == 0 ||
                  pac.obesidad == 0 ||
                  pac.fisicabaja == 0 ||
                  pac.fisicamedia == 0 ||
                  pac.fisicaalta == 0 ||
                  pac.mamadia == 0 ||
                  pac.papadia == 0 ||
                  pac.abuelapater == 0 ||
                  pac.abuelamater == 0 ||
                  pac.abuelopater == 0 ||
                  pac.abuelomater == 0 ||
                  pac.sexo == 0 ||
                  pac.glucemia == 0
                  ) {



                pac.bajo += 1;
                pac.normal += 1;
                pac.sobrepeso += 1;
                pac.obesidad += 1;
                pac.fisicabaja += 1;
                pac.fisicamedia += 1;
                pac.fisicaalta += 1;
                pac.mamadia += 1;
                pac.papadia += 1;
                pac.abuelapater += 1;
                pac.abuelamater += 1;
                pac.abuelopater += 1;
                pac.abuelomater += 1;
                pac.sexo += 1;
                pac.glucemia += 1;






            }



        }

        public static void CalcularProbas(Paciente pac) {
            // Aqui se va a calcular las probabilidades de todos los atributos para cada caso
            double cant = pac.bajo + pac.normal + pac.sobrepeso + pac.obesidad;

           
            pac.Prob_bajo = pac.bajo / cant;
            pac.Prob_normal = pac.normal / cant;
            pac.Prob_sobrepeso = pac.sobrepeso / cant;
            pac.Prob_obesidad = pac.obesidad / cant;
            pac.Prob_fisicabaja = pac.fisicabaja / cant;
            pac.Prob_fisicamedia = pac.fisicamedia / cant;
            pac.Prob_fisicaalta = pac.fisicaalta / cant;


            pac.Prob_mamadia = pac.mamadia / cant;
            pac.Prob_papadia = pac.papadia / cant;
            pac.Prob_abuelapater = pac.abuelapater / cant;
            pac.Prob_abuelamater = pac.abuelamater / cant;
            pac.Prob_abuelopater = pac.abuelopater / cant;
            pac.Prob_abuelomater = pac.abuelomater / cant;
            pac.Prob_sexo = pac.sexo / cant;
            pac.Prob_glucemia = pac.glucemia / cant;


        }

        public static void VerificarDiabetes(Paciente nuevo, Paciente viejosi, Paciente viejono, double probGsi, double probGno) {
            Paciente nuevono = nuevo;
            double totalsi=1;
            double totalno=1;
            if (nuevo.bajo==1) {

                nuevo.Prob_bajo=viejosi.Prob_bajo;
                nuevono.Prob_bajo = viejono.Prob_bajo;

                totalsi =totalsi* nuevo.Prob_bajo;
                totalno =totalno* nuevono.Prob_bajo;

            }

            if (nuevo.normal == 1)
            {

                nuevo.Prob_normal = viejosi.Prob_normal;
                nuevono.Prob_normal= viejono.Prob_normal;
                totalsi = nuevo.Prob_normal;
                totalno = nuevono.Prob_normal;

            }

            if (nuevo.sobrepeso == 1)
            {

                nuevo.Prob_sobrepeso= viejosi.Prob_sobrepeso;
                nuevono.Prob_sobrepeso = viejono.Prob_sobrepeso;

                totalsi = nuevo.Prob_sobrepeso;
                totalno = nuevono.Prob_sobrepeso;


            }

            if (nuevo.obesidad == 1)
            {

                nuevo.Prob_obesidad = viejosi.Prob_obesidad;
                nuevono.Prob_obesidad= viejono.Prob_obesidad;

                totalsi = nuevo.Prob_obesidad;
                totalno = nuevono.Prob_obesidad;
            }



            if (nuevo.fisicabaja == 1) {

                nuevo.Prob_fisicabaja = viejosi.Prob_fisicabaja;
                nuevono.Prob_fisicabaja = viejono.Prob_fisicabaja;
                totalsi = totalsi * nuevo.Prob_fisicabaja;
                totalno = totalno*nuevono.Prob_fisicabaja;

            }
            if (nuevo.fisicamedia == 1)
            {

                nuevo.Prob_fisicamedia = viejosi.Prob_fisicamedia;
                nuevono.Prob_fisicamedia = viejono.Prob_fisicamedia;

                totalsi = totalsi * nuevo.Prob_fisicamedia;
                totalno = totalno * nuevono.Prob_fisicamedia;

            }

            if (nuevo.fisicaalta == 1)
            {

                nuevo.Prob_fisicaalta = viejosi.Prob_fisicaalta;
                nuevono.Prob_fisicaalta = viejono.Prob_fisicaalta;
                totalsi = totalsi * nuevo.Prob_fisicaalta;
                totalno = totalno * nuevono.Prob_fisicaalta;


            }

            if (nuevo.mamadia == 1)
            {
                nuevo.Prob_mamadia = viejosi.Prob_mamadia;
                nuevono.Prob_mamadia = viejono.Prob_mamadia;
                totalsi = totalsi * nuevo.Prob_mamadia;
                totalno = totalno * nuevono.Prob_mamadia;

            }
            else {
                nuevo.Prob_mamadia = 1-viejosi.Prob_mamadia;
                nuevono.Prob_mamadia = 1-viejono.Prob_mamadia;
                totalsi = totalsi * (1 - viejosi.Prob_mamadia);
                totalno = totalno *(1 - viejono.Prob_mamadia);
            }

            if (nuevo.papadia == 1)
            {
                nuevo.Prob_papadia = viejosi.Prob_papadia;
                nuevono.Prob_papadia = viejono.Prob_papadia;
                totalsi = totalsi * nuevo.Prob_papadia;
                totalno = totalno * nuevono.Prob_papadia;


            }
            else
            {
                nuevo.Prob_papadia = 1 - viejosi.Prob_papadia;
                nuevono.Prob_papadia = 1 - viejono.Prob_papadia;

                totalsi = totalsi * (1 - viejosi.Prob_papadia);
                totalno = totalno * (1 - viejono.Prob_papadia);
            }

            if (nuevo.abuelamater == 1)
            {
                nuevo.Prob_abuelamater = viejosi.Prob_abuelamater;
                nuevono.Prob_abuelamater = viejono.Prob_abuelamater;

                totalsi = totalsi * nuevo.Prob_abuelamater;
                totalno = totalno * nuevono.Prob_abuelamater;


            }
            else
            {
                nuevo.Prob_abuelamater = 1 - viejosi.Prob_abuelamater;
                nuevono.Prob_abuelamater = 1 - viejono.Prob_abuelamater;

                totalsi = totalsi * (1 - viejosi.Prob_abuelamater);
                totalno = totalno * (1 - viejono.Prob_abuelamater);

            }

            if (nuevo.abuelomater == 1)
            {
                nuevo.Prob_abuelomater = viejosi.Prob_abuelomater;
                nuevono.Prob_abuelomater = viejono.Prob_abuelomater;

                totalsi = totalsi * nuevo.Prob_abuelomater;
                totalno = totalno * nuevono.Prob_abuelomater;


            }
            else
            {
                nuevo.Prob_abuelomater = 1 - viejosi.Prob_abuelomater;
                nuevono.Prob_abuelomater = 1 - viejono.Prob_abuelomater;

                totalsi = totalsi * (1 - viejosi.Prob_abuelomater);
                totalno = totalno * (1 - viejono.Prob_abuelomater);

            }

            if (nuevo.abuelapater == 1)
            {
                nuevo.Prob_abuelapater = viejosi.Prob_abuelapater;
                nuevono.Prob_abuelapater = viejono.Prob_abuelapater;

                totalsi = totalsi * nuevo.Prob_abuelapater;
                totalno = totalno * nuevono.Prob_abuelapater;

            }
            else
            {
                nuevo.Prob_abuelapater = 1 - viejosi.Prob_abuelapater;
                nuevono.Prob_abuelapater = 1 - viejono.Prob_abuelapater;

                totalsi = totalsi * (1 - viejosi.Prob_abuelapater);
                totalno = totalno * (1 - viejono.Prob_abuelapater);

            }

            if (nuevo.abuelopater == 1)
            {
                nuevo.Prob_abuelopater = viejosi.Prob_abuelopater;
                nuevono.Prob_abuelopater = viejono.Prob_abuelopater;

                totalsi = totalsi * nuevo.Prob_abuelopater;
                totalno = totalno * nuevono.Prob_abuelopater;

            }
            else
            {
                nuevo.Prob_abuelopater = 1 - viejosi.Prob_abuelopater;
                nuevono.Prob_abuelopater = 1 - viejono.Prob_abuelopater;

                totalsi = totalsi * (1 - viejosi.Prob_abuelopater);
                totalno = totalno * (1 - viejono.Prob_abuelopater);




            }

            if (nuevo.glucemia == 1)
            {
                nuevo.Prob_glucemia = viejosi.Prob_glucemia;
                nuevono.Prob_glucemia = viejono.Prob_glucemia;


                totalsi = totalsi * nuevo.Prob_glucemia;
                totalno = totalno * nuevono.Prob_glucemia;

            }
            else
            {
                nuevo.Prob_glucemia= 1 - viejosi.Prob_glucemia;
                nuevono.Prob_glucemia = 1 - viejono.Prob_glucemia;

                totalsi = totalsi * (1 - viejosi.Prob_glucemia);
                totalno = totalno * (1 - viejono.Prob_glucemia);

            }




            
            double probsi = totalsi * probGsi;
            double probno = totalno * probGno;

            MessageBox.Show("Total si " + probsi+" Total no: "+ probno);

            if (probsi > probno)
            {
                nuevo.propens = 1;

            }
            else {
                nuevo.propens = 0;
            }



        }

        public static List<Paciente> obtener()
        {
            List<Paciente> lista = new List<Paciente>();
            MySqlCommand comando = new MySqlCommand(string.Format("Select * from red"), BDConexion.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Paciente nuevo = new Paciente();
                nuevo.id = reader.GetInt32(0);
                nuevo.bajo = reader.GetInt32(1);
                nuevo.normal = reader.GetInt32(2);
                nuevo.sobrepeso = reader.GetInt32(3);
                nuevo.obesidad = reader.GetInt32(4);
                nuevo.fisicabaja = reader.GetInt32(5);
                nuevo.fisicamedia = reader.GetInt32(6);
                nuevo.fisicaalta = reader.GetInt32(7);
                nuevo.mamadia = reader.GetInt32(8);
                nuevo.papadia = reader.GetInt32(9);
                nuevo.abuelapater = reader.GetInt32(10);
                nuevo.abuelamater = reader.GetInt32(11);
                nuevo.abuelopater = reader.GetInt32(12);
                nuevo.abuelomater = reader.GetInt32(13);
                nuevo.sexo = reader.GetInt32(14);
                nuevo.glucemia = reader.GetInt32(15);
                nuevo.propens = reader.GetInt32(16);
                lista.Add(nuevo);
            }
            return lista;
        }
    }
}


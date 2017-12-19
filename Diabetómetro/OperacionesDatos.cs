using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    class OperacionesDatos
    {
        public static Datos Entrenar_SI()
        {
            Datos nuevo = new Datos();
            int i = 1;
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM info where salida='{0}'", i), BDConexion.ObtenerConexion());
            MySqlDataReader reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                String estado = reader.GetString(1);
                String profesion = reader.GetString(2);
                String uni = reader.GetString(3);
                String veh = reader.GetString(4);
                if (estado.Equals("casado"))
                {
                    nuevo.casado += 1;
                }
                else
                {
                    if (estado.Equals("soltero"))
                        nuevo.soltero += 1;
                    else
                        nuevo.viudo += 1;
                }
                if (profesion.Equals("Empresario"))
                    nuevo.empresario += 1;
                else
                {
                    if (profesion.Equals("Empleado"))
                        nuevo.empleado += 1;
                    else
                    {
                        if (profesion.Equals("Desempleado"))
                            nuevo.desempleado += 1;
                    }
                }
                if (uni.Equals("Si"))
                    nuevo.si_uni += 1;
                else
                    nuevo.no_uni += 1;
                if (veh.Equals("Si"))
                    nuevo.si_veh += 1;
                else
                    nuevo.no_veh += 1;
                nuevo.tam += 1;
            }
            return nuevo;
        }

        public static Datos Entrenar_NO()
        {
            Datos nuevo = new Datos();
            int i = 0;
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM info where salida='{0}'", i), BDConexion.ObtenerConexion());
            MySqlDataReader reader = _comando.ExecuteReader();
            while (reader.Read())
            {
                String estado = reader.GetString(1);
                String profesion = reader.GetString(2);
                String uni = reader.GetString(3);
                String veh = reader.GetString(4);
                if (estado.Equals("casado"))
                {
                    nuevo.casado += 1;
                }
                else
                {
                    if (estado.Equals("soltero"))
                        nuevo.soltero += 1;
                    else
                        nuevo.viudo += 1;
                }
                if (profesion.Equals("Empresario"))
                    nuevo.empresario += 1;
                else
                {
                    if (profesion.Equals("Empleado"))
                        nuevo.empleado += 1;
                    else
                    {
                        if (profesion.Equals("Desempleado"))
                            nuevo.desempleado += 1;
                    }
                }
                if (uni.Equals("Si"))
                    nuevo.si_uni += 1;
                else
                    nuevo.no_uni += 1;
                if (veh.Equals("Si"))
                    nuevo.si_veh += 1;
                else
                    nuevo.no_veh += 1;
                nuevo.tam += 1;
            }
            return nuevo;
        }

        public static void Comprobar(Datos dato)
        {
            if (dato.casado == 0 || dato.desempleado == 0 || dato.empleado == 0 || dato.empresario == 0 || dato.no_uni == 0 || dato.no_veh == 0 || dato.si_uni == 0 || dato.si_veh == 0 || dato.soltero == 0 || dato.viudo == 0)
            {
                dato.casado += 1;
                dato.desempleado += 1;
                dato.empleado += 1;
                dato.empresario += 1;
                dato.no_uni += 1;
                dato.no_veh += 1;
                dato.si_uni += 1;
                dato.si_veh += 1;
                dato.soltero += 1;
                dato.viudo += 1;
            }
        }

        public static void Obtener_probabilidades(Datos dato)
        {
            int total = 0;
            total = dato.viudo + dato.casado + dato.soltero;
            dato.prob_casado = Convert.ToDouble(Convert.ToDouble(dato.viudo) / Convert.ToDouble(total));
            Console.WriteLine(dato.prob_casado);
        }



    }
}

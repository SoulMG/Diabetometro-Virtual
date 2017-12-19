/*EPI Prática Evidencia Integradora
Integrantes:
Heredia Sánchez Carlos Alejandro - HSCO142603
Martínez García José Alfredo -  MGJO141686
Moreno Millán Keila Giovanna - MMKO140065
Reyes Ordaz Josephat - ROJO141217
Ingeniería en Informática(IIF)
Profesora: Alma Delia Nieto Yañez
Grado y Grupo: 8°A
Fecha de entrega: 13/08/2017
Materia: Programación Avanzada
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

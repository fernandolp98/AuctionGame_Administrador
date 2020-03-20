using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(!DbConnection.consulta_conexion())
            {
                MessageBox.Show(@"No se pudo conectar a la base de datos, verifique su configuración.");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainMenu());

            //var routine = Routine.GetRoutineById(1);
            //Application.Run(new FrmGame(routine, 500, new Time(0, 1, 0), null));

        }
    }
}

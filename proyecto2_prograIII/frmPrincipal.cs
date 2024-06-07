using proyecto2_prograIII.AVL;
using proyecto2_prograIII.LinkedList;
using proyecto2_prograIII.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2_prograIII
{
    public partial class frmPrincipal : Form
    {

        public clsListaEnlazada lista = new clsListaEnlazada();
        public clsArbolAVL avl = new clsArbolAVL();

        public frmPrincipal()
        {
            InitializeComponent();
            //mtdLeerJugadores();
            //mtdLeerEquipos();
            mtdInicializar();
        }



        private void mtdLeerJugadores()
        {
            //clsArbolAVL.nuevoArbol(null,arbolavl,null);

            string directorioActual = Directory.GetCurrentDirectory();

            string rutaRelativa = Path.Combine(directorioActual, @"..\..\Resources\PremierLeague18_19_Jugadores.csv");


            if (!File.Exists(rutaRelativa))
            {

                MessageBox.Show(directorioActual);
                MessageBox.Show("El archivo no existe.");
                return;
                
            }
            
            //clsListaEnlazada lista = new clsListaEnlazada();
                        

            try
            {
                using (StreamReader reader = new StreamReader(rutaRelativa))
                {
                    string line;
                    bool header = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Saltar la primera línea si es un encabezado
                        if (header)
                        {
                            header = false;
                            continue;
                        }

                        string[] parts = line.Split(',');
                        if (parts.Length == 9)
                        {
                            clsJugadorEst player = new clsJugadorEst(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8]);
                            lista.AgregarFinal(new clsNodoLK(player));
                        }
                        else
                        {
                            MessageBox.Show("Formato de línea incorrecto: " + line);
                        }
                    }
                }

                // Mostrar 
                //return lista;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
                //return null;
            }

        }

       

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form equipo = new frmEquipo();
            equipo.Show();
        }


        private void mtdInicializar()
        {

            this.WindowState = FormWindowState.Maximized;
        }

        private void juadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form jugadir = new frmJugador();
            jugadir.Show();

        }

        private void torneosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form partidos = new frmPartidos();
            partidos.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void CenterControlInPanel(Control control, Control panel)
        {
            // Calcular nueva posición
            int x = (panel.ClientSize.Width - control.Width) / 2;
            int y = (panel.ClientSize.Height - control.Height) / 2;

            // Establecer la nueva posición del control
            control.Location = new System.Drawing.Point(x, y);
        }

        private void TopControlInPanel(Control control, Control panel)
        {
            // Calcular nueva posición
            int x = (panel.ClientSize.Width - control.Width) / 2;
            int y = (panel.ClientSize.Height - control.Height) / 10;

            // Establecer la nueva posición del control
            control.Location = new System.Drawing.Point(x, y);
        }

        private void torneosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmTorneo();
            frm.Show();
        }
    }
}

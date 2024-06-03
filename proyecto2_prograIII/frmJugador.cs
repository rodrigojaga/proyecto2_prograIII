using proyecto2_prograIII.LinkedList;
using proyecto2_prograIII.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2_prograIII
{
    public partial class frmJugador : Form
    {

        clsListaEnlazada pl = new clsListaEnlazada();

        public frmJugador()
        {
            InitializeComponent();
            mtdLeerJugadores();
        }

        private void mtdLeerJugadores()
        {
            //PremierLeague18_19_Jugadores.csv
            string directorioActual = Directory.GetCurrentDirectory();
            string rutaRelativa = Path.Combine(directorioActual, @"..\..\Resources\PremierLeague18_19_Jugadores.csv");

            if (!File.Exists(rutaRelativa))
            {
                MessageBox.Show(directorioActual);
                MessageBox.Show("El archivo no existe.");
                return;
            }

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
                            pl.AgregarFinal(player);
                        }
                        else
                        {
                            MessageBox.Show("Formato de línea incorrecto: " + line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pl = new clsListaEnlazada();

            mtdLeerJugadores();

            lstJugadores.AcceptsReturn = true;
            lstJugadores.AcceptsTab = true;
            lstJugadores.WordWrap = true;
            lstJugadores.Multiline = true;
            lstJugadores.ScrollBars = ScrollBars.Both;

            lstJugadores.Text = pl.ImprimirLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {            

            if (string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtAsissts.Text) ||
                string.IsNullOrEmpty(txtAge.Text) ||
                string.IsNullOrEmpty(txtClub.Text) ||
                string.IsNullOrEmpty(txtGoals.Text) ||
                string.IsNullOrEmpty(txtPosition.Text) ||
                string.IsNullOrEmpty(txtNational.Text) ||
                string.IsNullOrEmpty(txtRed.Text) ||
                string.IsNullOrEmpty(txtYellow.Text)
                )
            {

                MessageBox.Show("Llene todos los campos");

            }
            else
            {                
               string a = pl.Modificar(new clsJugadorEst(txtFullName.Text.Trim()), new clsJugadorEst(txtFullName.Text,
               txtAge.Text,txtPosition.Text,txtNational.Text,txtGoals.Text,txtAsissts.Text,txtYellow.Text,txtRed.Text,
               txtClub.Text));
                MessageBox.Show(a);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pl.Eliminar(new clsJugadorEst(txtFullName.Text.Trim())));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtAsissts.Text) ||
                string.IsNullOrEmpty(txtAge.Text) ||
                string.IsNullOrEmpty(txtClub.Text) ||
                string.IsNullOrEmpty(txtGoals.Text) ||
                string.IsNullOrEmpty(txtPosition.Text) ||
                string.IsNullOrEmpty(txtNational.Text) ||
                string.IsNullOrEmpty(txtRed.Text) ||
                string.IsNullOrEmpty(txtYellow.Text)
                )
            {

                MessageBox.Show("Llene todos los campos");

            }
            else
            {
                try
                {

                    mtdAgregarEquipo();
                    mtdBlanqueado();

                }
                catch (Exception ez)
                {
                    MessageBox.Show("Algo salio mal " + ez.Message);
                }
            }
        }

        private void mtdAgregarEquipo()
        {
            string directorioActual = Directory.GetCurrentDirectory();
            string rutaRelativa = Path.Combine(directorioActual, @"..\..\Resources\PremierLeague18_19_Jugadores.csv");

            // Datos que deseas agregar
            string[] newRecords = new string[]
            {
            //full_name,age,position,nationality,goals_overall,assists_overall,yellow_cards_overall,red_cards_overall,Current Club
            $"{txtFullName.Text},{txtAge.Text},{txtPosition.Text},{txtNational.Text},{txtGoals.Text},{txtAsissts.Text},{txtYellow.Text},{txtRed.Text},{txtClub.Text}"
            };

            try
            {
                // Usar StreamWriter para abrir el archivo en modo append (agregar)
                using (StreamWriter sw = new StreamWriter(rutaRelativa, append: true))
                {
                    foreach (var record in newRecords)
                    {
                        sw.WriteLine(record);
                    }
                }

                MessageBox.Show("Datos agregados al archivo CSV exitosamente.");

                // Confirmar la escritura
                string fileContent = File.ReadAllText(rutaRelativa);
                //MessageBox.Show("Contenido actual del archivo:\n" + fileContent);

                mtdBlanqueado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir en el archivo: {ex.Message}");
            }
        }

        private void mtdBlanqueado()
        {
            txtFullName.Text = "";
            txtAge.Text = "";
            txtPosition.Text = "";
            txtNational.Text = "";
            txtGoals.Text = "";
            txtAsissts.Text = "";
            txtYellow.Text = "";
            txtRed.Text = "";
            txtClub.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsNodoLK tm = pl.buscar(new clsJugadorEst(txtBuscar.Text));

            if (tm != null)
            {
                clsJugadorEst en = (clsJugadorEst)tm.dato;
                txtFullName.Text = en.full_name;
                txtAge.Text = en.age;
                txtPosition.Text = en.position;
                txtNational.Text = en.nationality;
                txtGoals.Text = en.goals_overall;
                txtAsissts.Text = en.assists_overall;
                txtYellow.Text = en.yellow_cards_overall;
                txtRed.Text = en.red_cards_overall;
                txtClub.Text = en.Current_Club;
            }
            else
            {
                MessageBox.Show("Malo");
            }
        }
    }
}

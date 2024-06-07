using proyecto2_prograIII.AVL;
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
    public partial class frmEquipo : Form
    {

        public clsArbolAVL avl = new clsArbolAVL();

        public frmEquipo()
        {
            InitializeComponent();
            mtdLeerEquipos();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void mtdLeerEquipos()
        {
            string directorioActual = Directory.GetCurrentDirectory();
            string rutaRelativa = Path.Combine(directorioActual, @"..\..\Resources\PremierLeague18_19_Equipos.csv");

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
                        if (line.StartsWith("#"))
                        {
                            continue;
                        }
                        // Saltar la primera línea si es un encabezado
                        if (header)
                        {
                            header = false;
                            continue;
                        }

                        string[] parts = line.Split(',');
                        if (parts.Length == 8)
                        {
                            clsEquipos team = new clsEquipos(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);
                            avl.insertar(team);
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


        private void btnMostrarE_Click(object sender, EventArgs e)
        {
            avl = new clsArbolAVL();
            mtdLeerEquipos();
            lstEquipo.AcceptsReturn = true;
            lstEquipo.AcceptsTab = true;
            lstEquipo.WordWrap = true;
            lstEquipo.Multiline = true;
            lstEquipo.ScrollBars = ScrollBars.Both;

            lstEquipo.Text = clsArbolAVL.preorden(avl.raizArbol());

            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCommonName.Text) ||
                string.IsNullOrEmpty(txtCountry.Text) ||
                string.IsNullOrEmpty(txtDraws.Text) ||
                string.IsNullOrEmpty(txtLosses.Text) ||
                string.IsNullOrEmpty(txtMatches.Text) ||
                string.IsNullOrEmpty(txtTeamName.Text) ||
                string.IsNullOrEmpty(txtWins.Text)  ||
                string.IsNullOrEmpty(txtPerfomanceRank.Text)
                )
            {

                MessageBox.Show("FILL IN AL THE GAPS");

            }
            else
            {
                try
                {
                     
                    mtdAgregarEquipo();

                }catch(Exception ez)
                {
                    MessageBox.Show("Algo salio mal "+ez.Message);
                }
            }
        }

        private void mtdAgregarEquipo()
        {
            string directorioActual = Directory.GetCurrentDirectory();
            string rutaRelativa = Path.Combine(directorioActual, @"..\..\Resources\PremierLeague18_19_Equipos.csv");

            // Datos que deseas agregar
            string[] newRecords = new string[]
            {
        //team_name,common_name,country,matches_played,wins,draws,losses
            $"{txtTeamName.Text},{txtCommonName.Text},{txtCountry.Text}," +
            $"{txtMatches.Text},{txtWins.Text},{txtDraws.Text},{txtLosses.Text}, {txtPerfomanceRank.Text}"
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
                MessageBox.Show("Contenido actual del archivo:\n" + fileContent);

                mtdBlanqueado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir en el archivo: {ex.Message}");
            }
        }

        private void mtdBlanqueado()
        {
            txtTeamName.Text = ""; 
            txtCommonName.Text = "";
            txtCountry.Text = "";
            txtMatches.Text = "";
            txtWins.Text = "";
            txtDraws.Text = "";            
            txtLosses.Text = "";
            txtPerfomanceRank.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            avl = new clsArbolAVL();
            mtdLeerEquipos();
            clsValorYSaltos vs = avl.buscar(new clsEquipos(txtBuscar.Text.Trim()));
            
            clsEquipos c = (clsEquipos)((clsNodoAVL)vs.obj).valorNodo();

            txtTeamName.Text = c.team_name;
            txtCommonName.Text = c.common_name;
            txtCountry.Text = c.country;
            txtMatches.Text = c.matches_played;
            txtWins.Text = c.wins;
            txtDraws.Text = c.draws;
            txtLosses.Text = c.losse;
            txtPerfomanceRank.Text = c.performance_rank;


        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCommonName.Text))
            {
                MessageBox.Show("Debe buscar el equipo primero");
            }else if (avl.buscar(new clsEquipos(txtCommonName.Text)).obj == null)
            {
                MessageBox.Show("Not found");

            }
            else
            {
                avl.eliminar(new clsEquipos(txtCommonName.Text));
                MessageBox.Show("Equipo borrado");
            }

        }
    }
}

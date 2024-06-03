using proyecto2_prograIII.HashTable;
using proyecto2_prograIII.HashTable.LinkedListHash;
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
    public partial class frmPartidos : Form
    {

        clsTablaHash partidosHash = new clsTablaHash(400);

        public frmPartidos()
        {
            InitializeComponent();
            mtdLeerPartidos();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void mtdLeerPartidos()
        {
            //PremierLeague18_19_Partidos.csv
            string directorioActual = Directory.GetCurrentDirectory();
            string rutaRelativa = Path.Combine(directorioActual, @"..\..\Resources\PremierLeague18_19_Partidos.csv");
            int i = 0;
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
                            clsPartido game = new clsPartido(parts[0], parts[1], parts[2], 
                                                            parts[3], parts[4], parts[5], 
                                                            parts[6], parts[8]);
                            //clave
                            long clave = game.convertirASCII();
                                                        
                            partidosHash.insertar(clave,game);
                            
                        }
                        else
                        {
                            MessageBox.Show("Formato de línea incorrecto: " + line);
                        }
                        i++;
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

            partidosHash = new clsTablaHash(400);

            mtdLeerPartidos();

            lstPartidos.AcceptsReturn = true;
            lstPartidos.AcceptsTab = true;
            lstPartidos.WordWrap = true;
            lstPartidos.Multiline = true;
            lstPartidos.ScrollBars = ScrollBars.Both;
            

            lstPartidos.Text = partidosHash.leerTodo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string date = txtBuscarDate.Text;
            string home = txtBuscarHome.Text;
            string away = txtBuscarAway.Text;
            if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(home) || string.IsNullOrEmpty(away))
            {
                MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS SOLICITADOS");
            }
            else
            {
                clsPartido p = new clsPartido(date,home,away);
                clsNodoLKHash z = partidosHash.buscar(p);
                if (z != null)
                {


                    if (z.dato is clsNodoLKHash)
                    {
                        clsPartido at = (clsPartido)((clsNodoLKHash)z.dato).dato;
                        MessageBox.Show(at.ToString());
                        txtStadium.Text = at.stadium_name;
                        txtHome.Text = at.home_team_name;
                        txtAway.Text = at.away_team_name;
                        txtTotalGo.Text = at.total_goal_count;
                        txtHomeGo.Text = at.home_team_goal_count;
                        txtAwayGo.Text = at.away_team_goal_count;
                        txtDate.Text = at.date_GMT;
                        txtReferee.Text = at.referee;
                        txtStatus.Text = at.status;



                    }
                    else
                    {
                        clsPartido at = (clsPartido)z.dato;
                        MessageBox.Show(at.ToString());
                        txtStadium.Text = at.stadium_name;
                        txtHome.Text = at.home_team_name;
                        txtAway.Text = at.away_team_name;
                        txtTotalGo.Text = at.total_goal_count;
                        txtHomeGo.Text = at.home_team_goal_count;
                        txtAwayGo.Text = at.away_team_goal_count;
                        txtDate.Text = at.date_GMT;
                        txtReferee.Text = at.referee;
                        txtStatus.Text = at.status;

                    }

                }
                else
                {
                    MessageBox.Show("Objeto no encontrado");
                }
            }
        }


        private void mtdBlanqueado()
        {
            txtStadium.Text = "";
            txtHome.Text = "";
            txtAway.Text = "";
            txtTotalGo.Text = "";
            txtHomeGo.Text = "";
            txtAway.Text = "";
            txtDate.Text = "";
            txtReferee.Text = "";
            txtStatus.Text = "";
            //txtBuscarAway.Text = "";
            //txtBuscarDate.Text = "";
            //txtBuscarHome.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string date = txtBuscarDate.Text;
            string home = txtBuscarHome.Text;
            string away = txtBuscarAway.Text;
            if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(home) || string.IsNullOrEmpty(away))
            {
                MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS SOLICITADOS");
            }
            else
            {
                clsPartido p = new clsPartido(date, home, away);
                string response = partidosHash.eliminar(p);
                if (!string.IsNullOrEmpty(response))
                {
                    MessageBox.Show(response);
                }
                else
                {
                    MessageBox.Show("Objeto no encontrado");
                }

                mtdBlanqueado();


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //datos
            string stadium = txtStadium.Text;
            string home = txtHome.Text;
            string away = txtAway.Text;
            //string goals = txtTotalGo.Text;
            string homeGo = txtHomeGo.Text;
            string awayGo = txtAwayGo.Text;
            string date = txtDate.Text;
            string referee = txtReferee.Text;
            string status = txtStatus.Text; 

            clsPartido nuevoValor = new clsPartido(date, status, home, away, referee,homeGo,awayGo //,goals
                ,stadium);

            string buscarDate = txtBuscarDate.Text;
            string buscarHome = txtBuscarHome.Text;
            string buscarAway = txtBuscarAway.Text;

            clsPartido clave = new clsPartido(buscarDate,buscarHome,buscarAway);

            string response = partidosHash.modificar(clave, nuevoValor);

            if (!string.IsNullOrEmpty(response))
            {
                MessageBox.Show(response);
                mtdBlanqueado();
            }
            else
            {
                MessageBox.Show("Objeto no encontrado");
            }
        }
    }
}

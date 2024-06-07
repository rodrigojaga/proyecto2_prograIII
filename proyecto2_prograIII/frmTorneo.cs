using proyecto2_prograIII.AVL;
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
    public partial class frmTorneo : Form
    {

        clsTablaHash torneoHash = new clsTablaHash(150);
        clsArbolAVL[] torneoAvl = new clsArbolAVL[100];
        clsListaEnlazada partidoLista = new clsListaEnlazada();
        clsListaEnlazada equipoLista = new clsListaEnlazada();
        clsListaEnlazada jugadoresLista = new clsListaEnlazada();

        public frmTorneo()
        {
            InitializeComponent();
            //mtdLeerPartidos();
            mtdLeerPartidosLista();
            mtdLeerEquiposLista();
            mtdLeerJugadoresLista();
            mtdLeerPartidosPrueba();
            mtdMeterATablaHash();
            textBox1.Text = "Aug 11 2018 - 2:00pm - Vitality Stadium (Bournemouth- Dorset) \r\n" +
                "Aug 11 2018 - 2:00pm - John Smith's Stadium (Huddersfield- West Yorkshire) \r\n" +
                "Aug 11 2018 - 4:30pm - Molineux Stadium (Wolverhampton- West Midlands) \r\n" +
                "O con otro torneo: \r\n" +
                "Huddersfield Town - Cardiff City - (Aug 25 2018 - 2:00pm) - John Smith's Stadium (Huddersfield- West Yorkshire) \r\n" +
                "Aug 25 2018 - 4:30pm - Anfield (Liverpool)";
        }

        private void mtdLeerPartidos()
        {
            //PremierLeague18_19_Partidos.csv
            string directorioActual = Directory.GetCurrentDirectory();
            string rutaRelativa = Path.Combine(directorioActual, @"..\..\Resources\PremierLeague18_19_Partidos.csv");
            int i = 0;
            int j = 0;
            string lastDate = string.Empty; // Variable para almacenar la última fecha procesada

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
                    bool isFirstLine = true;
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

                            string[] dateTimeParts = parts[0].Split('-');
                            string datePart = dateTimeParts[0].Trim();

                            // Comprobar si la fecha es igual a la última fecha procesada
                            if (isFirstLine)
                            {
                                lastDate = datePart;
                                isFirstLine = false;
                            }
                            else if (!datePart.Equals(lastDate))
                            {
                                // Si las fechas son diferentes, actualizar la última fecha y cambiar el índice j
                                lastDate = datePart;
                                j++;
                            }
                            // Verificar si j excede el tamaño del array y expandir si es necesario
                            if (j >= torneoAvl.Length)
                            {
                                Array.Resize(ref torneoAvl, torneoAvl.Length * 2);
                            }

                            // Inicializar el árbol AVL si no está inicializado
                            if (torneoAvl[j] == null)
                            {
                                torneoAvl[j] = new clsArbolAVL();
                            }

                            torneoAvl[j].insertar(game);

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

        private void mtdLeerPartidosPrueba()
        {
           
            //int i = 0;
            int j = 0;
            string lastDate = string.Empty; // Variable para almacenar la última fecha procesada

            try


            {
                
                bool isFirstLine = true;
                clsListaEnlazada l = Leer();

                foreach (clsTorneo torneo in l)
                {
                    string[] dateTimeParts = torneo.partido.date_GMT.Split('-');
                    string datePart = dateTimeParts[0].Trim();

                    if (isFirstLine)
                    {
                        lastDate = datePart;
                        isFirstLine = false;
                    }
                    else if (!datePart.Equals(lastDate))
                    {
                        // Si las fechas son diferentes, actualizar la última fecha y cambiar el índice j
                        lastDate = datePart;
                        j++;
                    }
                    // Verificar si j excede el tamaño del array y expandir si es necesario
                    if (j >= torneoAvl.Length)
                    {
                        Array.Resize(ref torneoAvl, torneoAvl.Length * 2);
                    }

                    // Inicializar el árbol AVL si no está inicializado
                    if (torneoAvl[j] == null)
                    {
                        torneoAvl[j] = new clsArbolAVL();
                    }

                    torneoAvl[j].insertar(torneo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

        private void mtdMeterATablaHash()
        {
            for (int i = 0; i <torneoAvl.Length; i++)
            {
                //identificamos la posicion en la tabla hash segun el valor del nodo raiz del arbol AVL
                if (torneoAvl[i] != null)
                {
                    clsTorneo torneo = (clsTorneo)(torneoAvl[i].raizArbol()).valorNodo();
                    torneoHash.insertar(torneo.convertirASCII(), torneoAvl[i]);
                }
                
            }
            //foreach(clsArbolAVL arbol in torneoAvl)
            //{
                
            //}
        }

        private void mtdLeerJugadoresLista()
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
                        if (parts.Length == 9)
                        {
                            clsJugadorEst player = new clsJugadorEst(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8]);
                            jugadoresLista.AgregarFinal(player);
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

        private void mtdLeerPartidosLista()
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
                        if (parts.Length == 9)
                        {
                            clsPartido game = new clsPartido(parts[0], parts[1], parts[2],
                                                            parts[3], parts[4], parts[5],
                                                            parts[6], parts[8]);
                            partidoLista.AgregarFinal(game);                            

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

        private void mtdLeerEquiposLista()
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
                            equipoLista.AgregarFinal(team);
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

        private clsListaEnlazada Leer()
        {
            clsListaEnlazada torneos = new clsListaEnlazada();

            foreach (var partido in partidoLista)
            {
                clsPartido partidoNuevo = (clsPartido)partido;
                clsEquipos equipo1 = null;
                clsEquipos equipo2 = null;
                List<clsJugadorEst> jugadores1 = new List<clsJugadorEst>();
                List<clsJugadorEst> jugadores2 = new List<clsJugadorEst>();

                string equipoCasa = partidoNuevo.home_team_name;
                string equipoVisitante = partidoNuevo.away_team_name;

                foreach (clsEquipos equipo in equipoLista)
                {
                    if (equipoCasa.Equals(equipo.common_name))
                    {
                        equipo1 = equipo;
                        foreach (clsJugadorEst jugador in jugadoresLista)
                        {
                            if (equipo1.common_name.Equals(jugador.Current_Club))
                            {
                                jugadores1.Add(jugador);
                            }
                        }
                    }
                    else if (equipoVisitante.Equals(equipo.common_name))


                    {
                        equipo2 = equipo;
                        foreach (clsJugadorEst jugador in jugadoresLista)
                        {
                            if (equipo2.common_name.Equals(jugador.Current_Club))
                            {
                                jugadores2.Add(jugador);
                            }
                        }
                    }
                }

                // Convertir la lista de jugadores a arrays
                clsJugadorEst[] arrayJugadores1 = jugadores1.ToArray();
                clsJugadorEst[] arrayJugadores2 = jugadores2.ToArray();

                if(partidoNuevo != null && equipo1 != null && equipo2 != null && arrayJugadores1.Length != 0 && arrayJugadores2.Length != 0)
                    torneos.AgregarFinal(new clsTorneo(partidoNuevo, equipo1, equipo2, arrayJugadores1, arrayJugadores2));
            }

            return torneos;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string home = txtBuscarHome.Text;
            string away = txtBuscarAway.Text;
            string date = txtBuscarDate.Text;
            string stadium = txtBuscarStadium.Text;

            string espeDate = txtEspeDate.Text;
            string espeStadium = txtEspeStadium.Text;

            long asciiSum = 0;
            string compararThis = home + away + date+stadium;
            foreach (char c in compararThis)
            {
                asciiSum += (int)c; // Sumar el valor ASCII del carácter
            }
            clsPartido p = new clsPartido(home,away,date,stadium);

            clsTorneo t = new clsTorneo(p);

            clsNodoLKHash z =  torneoHash.buscar(t);
            if (z != null)
            {


                if (z.dato is clsNodoLKHash)
                {
                    clsArbolAVL at = (clsArbolAVL)((clsNodoLKHash)z.dato).dato;
                    clsValorYSaltos ne =  at.buscar(new clsTorneo(new clsPartido(espeDate,espeStadium)));
                    clsTorneo encontrado = ((clsTorneo)((clsNodoAVL)ne.obj).valorNodo());

                    MessageBox.Show(encontrado.ToString());

                    clsPartido partido = encontrado.partido;
                    clsEquipos equipoHome = encontrado.equipo1;
                    clsEquipos equipoAway = encontrado.equipo2;

                    txtHomeEN.Text = equipoHome.common_name;
                    txtAwayEN.Text = equipoAway.common_name;
                    txtStadiumEN.Text = partido.stadium_name;
                    txtFechaEN.Text = partido.date_GMT;

                    StringBuilder sbHome = new StringBuilder();
                    foreach(clsJugadorEst jugador in encontrado.jugadoresEquipoHome)
                    {
                        sbHome.Append(jugador.ToString());
                    }

                    StringBuilder sbAway = new StringBuilder();
                    foreach (clsJugadorEst jugador in encontrado.jugadoresEquipoAway)
                    {
                        sbAway.Append(jugador.ToString());
                    }

                    txtJugadoresHome.AcceptsReturn = true;
                    txtJugadoresHome.AcceptsTab = true;
                    txtJugadoresHome.WordWrap = true;
                    txtJugadoresHome.Multiline = true;
                    txtJugadoresHome.ScrollBars = ScrollBars.Both;
                    txtJugadoresAway.AcceptsReturn = true;
                    txtJugadoresAway.AcceptsTab = true;
                    txtJugadoresAway.WordWrap = true;
                    txtJugadoresAway.Multiline = true;
                    txtJugadoresAway.ScrollBars = ScrollBars.Both;

                    txtJugadoresHome.Text = sbHome.ToString();
                    txtJugadoresAway.Text = sbAway.ToString();


                }
                else
                {
                    clsArbolAVL at = (clsArbolAVL)z.dato;
                    clsValorYSaltos ne = at.buscar(new clsTorneo(new clsPartido(espeDate, espeStadium)));
                    clsTorneo encontrado = ((clsTorneo)((clsNodoAVL)ne.obj).valorNodo());

                    MessageBox.Show(encontrado.ToString());

                    clsPartido partido = encontrado.partido;
                    clsEquipos equipoHome = encontrado.equipo1;
                    clsEquipos equipoAway = encontrado.equipo2;

                    txtHomeEN.Text = equipoHome.common_name;
                    txtAwayEN.Text = equipoAway.common_name;
                    txtStadiumEN.Text = partido.stadium_name;
                    txtFechaEN.Text = partido.date_GMT;

                    StringBuilder sbHome = new StringBuilder();
                    foreach (clsJugadorEst jugador in encontrado.jugadoresEquipoHome)
                    {
                        sbHome.Append(jugador.ToString());
                    }

                    StringBuilder sbAway = new StringBuilder();
                    foreach (clsJugadorEst jugador in encontrado.jugadoresEquipoAway)
                    {
                        sbAway.Append(jugador.ToString());
                    }

                    txtJugadoresHome.AcceptsReturn = true;
                    txtJugadoresHome.AcceptsTab = true;
                    txtJugadoresHome.WordWrap = true;
                    txtJugadoresHome.Multiline = true;
                    txtJugadoresHome.ScrollBars = ScrollBars.Both;
                    txtJugadoresAway.AcceptsReturn = true;
                    txtJugadoresAway.AcceptsTab = true;
                    txtJugadoresAway.WordWrap = true;
                    txtJugadoresAway.Multiline = true;
                    txtJugadoresAway.ScrollBars = ScrollBars.Both;

                    txtJugadoresHome.Text = sbHome.ToString();
                    txtJugadoresAway.Text = sbAway.ToString();


                }

            }
            else
            {
                MessageBox.Show("Item not found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(clsArbolAVL arbol in torneoAvl)
            {
                MessageBox.Show(((clsTorneo)(((clsNodoAVL)arbol.raizArbol()).valorNodo())).ToString());
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}

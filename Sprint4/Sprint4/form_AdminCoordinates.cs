using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI
{
    public partial class form_AdminCoordinates : Form
    {
        public form_AdminCoordinates()
        {
            InitializeComponent();
        }

        private void form_AdminCoordinates_FormClosing(object sender, FormClosingEventArgs e)
        {
            Assembly asm = Assembly.GetEntryAssembly();
            Type formtype = asm.GetType(string.Format("{0}.{1}", "Sprint4", "FormPrincipal"));

            Form frmTrustedUsers = (Form)Activator.CreateInstance(formtype);
            frmTrustedUsers.Show();

            this.Hide();
        }

        Dictionary<string, string> coordenades = new Dictionary<string, string>();
        List<String> LletrasNumeros = new List<string>();

        private void form_AdminCoordinates_Load(object sender, EventArgs e)
        {
            //tlpCoordinates.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;

            FuncionesDB db = new FuncionesDB();
            DataSet dts = new DataSet();
            coordenades.Clear();

            string LletraNumero;

            int columna = tlpCoordinates.ColumnCount - 1;
            int row2 = tlpCoordinates.RowCount - 1;

            int total_casellas = columna * row2;

            dts = db.PortarTaula("AdminCoordinates");

            DataTable tabla = dts.Tables["AdminCoordinates"];

            foreach(DataRow row in tabla.Rows)
            {
                string coordenada = row["Coordinate"].ToString();
                String numeroAleatorio = row["ValueCoord"].ToString();
                coordenades.Add(coordenada, numeroAleatorio);
            }

            for (char i = (char)65; i < (char)69; i++)
            {
                LletraNumero = Convert.ToString(i);
                for (int j = 1; j <= 5; j++)
                {
                    LletraNumero += j;
                    LletrasNumeros.Add(LletraNumero);
                    LletraNumero = Convert.ToString(i);
                }
                LletraNumero = "";
            }

            using (Font fuente = new Font("Nirmala UI", 12f, FontStyle.Bold))
            {
                for (int i = 0; i < total_casellas; i++)
                {
                    Label lb_panel = new Label();
                    lb_panel.Width = 100;
                    lb_panel.Height = 68;
                    lb_panel.Font = fuente;
                    lb_panel.Dock = DockStyle.None;
                    lb_panel.Anchor = AnchorStyles.None;

                    tlpCoordinates.Controls.Add(lb_panel);
                    lb_panel.Text = coordenades[LletrasNumeros[i]];
                }
            }
        }
    }
}
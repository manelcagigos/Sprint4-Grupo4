using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint4
{
    public partial class ObrirTauPas1 : Form
    {
        public ObrirTauPas1()
        {
            InitializeComponent();
        }

        public SqlConnection Connect()
        {
            SqlConnection conn;
            string cnx = ConfigurationManager.ConnectionStrings["DataConnection"].ConnectionString;

            conn = new SqlConnection(cnx);

            return conn;
        }

        public void Ejecutar(string query)
        {
            try
            {
                SqlConnection conn = Connect();

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                int registresAfectats = cmd.ExecuteNonQuery();

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetByQuerry(string querry)
        {
            try
            {
                SqlConnection conn = Connect();
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);

                conn.Open();
                DataSet dts = new DataSet();
                adapter.Fill(dts);
                conn.Close();

                return dts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool qrOK = true;

            foreach (TextBox item in this.Controls)
            {
                if (item.Text == "")
                {
                    qrOK = false;
                }
            }

            if (qrOK)
            {
                Ejecutar("insert into CodeChain values(" + tb_usercode.Text+"," +codechain+ "," +QR+ ");");
                //(falta codechain y QR)
            }
            else
            {
                MessageBox.Show("Si us plau, omple els camps abans de crear el teu QR.");
            }
        }

        private void ObrirTauPas1_Load(object sender, EventArgs e)
        {

        }
    }
}

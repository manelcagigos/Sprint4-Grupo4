using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        qrOK = false;
                    }
                }

            }

            //En el insert de abajo, el primer elemento no es lo escrito en el textbox.
            //En el textbox el usuario escribira el codigo de usuario, que si lo miras en la base de datos (dbo.Users - Campo: codeUser)
            //Es su nombre, con ese texto del tb_usercode tiene que extraer la id de la base de datos, y eso es lo que guardaras
            //En la tabla CodeChain de la base de datos, pero piensa que primero va el id del codeChain, se supone que si usas la clase que sube
            //el dts a la base de datos, en vez de un insert, te tendria que poner automaticamente la id, es la unica manera para no repetir id nunca.
            //Luego codechain es el elemento que te genera al juntar todos los otros elementos y crear el qr, y qr no se lo que es.
            //Mira el enlace de abajo del todo de la ficha, para la creacion de qr's en c#.

            //Te he añadido la clase FuncionesDB, que estan todas las clases necesarias para actulizar y hacer cualquier cosa relacionada con la base de datos.

            //Una vez este todo esto hecho, tiene que haver otro boton, o el mismo, pero tendra que esperar a que acabe de subir lo datos primero.
            //Debera abrir un nuevo formulario (FormEscanearQR), en este formulario podra introducir su codeUser y buscara en la base de datos
            //su nombre completo (no existe, deberia estar en DescUser, pero estan vacios esos campos).
            //Un picturebox para la camara, si miras el primer video que hay en la ficha para generar el qr lo entendras al momento.
            //Y un textbox multilinea (un textbox normal, en el que si clicas a la flecha en el diseñador, te deja clicar a multilinea).
            //En este texbox aparecera los datos del qr (mirar primer video de la ficha).
            //Y por ultimo un boton que activara la camara (picturebox) para poder scanear el qr y verificar que es correcto.
            //Una vez este eso hecho la parte de coordenadas ya la hare yo o te ayudare, pero deberia ser un momento porque ya la tenemos hecha.
            //El form ya esta creado, falta el codigo, ademas de acabar el de aqui.

            if (qrOK)
            {
                if (GetByQuerry("select * from Users where idUser =" + tb_usercode).Tables.Count > 0)
                {

                    QRCodeGenerator qr = new QRCodeGenerator();
                    string dataqr = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text;
                    string codeChainMasked;
                    QRCodeData qdat = qr.CreateQrCode(dataqr, QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(qdat);

                    using (SHA256 hash = SHA256.Create())

                    {

                        byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(dataqr));

                        string strHash = BitConverter.ToString(hashedBytes);

                        codeChainMasked = strHash;

                    }

                    Ejecutar("insert into CodeChain values(" + tb_usercode.Text + "," + codeChainMasked + "," + code + ");");
                }
            }
            else
            {
                MessageBox.Show("Si us plau, omple els camps abans de crear el teu QR.");
            }
        }

        private void ObrirTauPas1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEscanearQR fm = new FormEscanearQR();
            fm.Show();
        }
    }
}

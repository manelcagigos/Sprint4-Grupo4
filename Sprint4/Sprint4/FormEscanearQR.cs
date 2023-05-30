using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Sprint4
{
    public partial class FormEscanearQR : Form
    {
        public FormEscanearQR()
        {
            InitializeComponent();
        }

        VideoCaptureDevice vd;
        FilterInfoCollection fic;
        private void lbNomUsuari_Click(object sender, EventArgs e)
        {

        }

        private void btValidarQR_Click(object sender, EventArgs e)
        {
            FuncionesDB func = new FuncionesDB();
            if (func.GetByQuerry("select * from Users where idUser =" + tb_usercode).Tables.Count > 0)
            {
                lbNomUsuari.Text = func.GetByQuerry("select descUser from Users where idUser = " + tb_usercode).Tables[0].AsEnumerable().First().ToString(); ; ;
                vd = new VideoCaptureDevice(fic[comboBox1.SelectedIndex].MonikerString);
                vd.NewFrame += new NewFrameEventHandler(vd_NewFrame);
                //video https://www.youtube.com/watch?v=0_u-9nykBrg
                vd.Start();
            }

        }

        private void vd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxCamara.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormEscanearQR_Load(object sender, EventArgs e)
        {
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in fic)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void FormEscanearQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vd.IsRunning)
            {
                vd.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxCamara.Image != null)
            {
                BarcodeReader br = new BarcodeReader();
                Result rs = br.Decode((Bitmap)pictureBoxCamara.Image);
                if (rs != null)
                {
                    tbMultilinea.Text = rs.ToString();
                    timer1.Stop();
                    if (vd.IsRunning)
                    {
                        vd.Stop();
                    }
                }
            }
        }

        private void btPrubeas_Click(object sender, EventArgs e)
        {
            form_AdminCoordinates frm = new form_AdminCoordinates();
            frm.Show();

            this.Hide();
        }
    }
}

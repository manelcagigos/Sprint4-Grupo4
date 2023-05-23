using MESSI;
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
                //vd.NewFrame += //evento newframe
                //video https://www.youtube.com/watch?v=0_u-9nykBrg
                vd.Start();
            }

        }

        private void FormEscanearQR_Load(object sender, EventArgs e)
        {
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in fic)
            {
                comboBox1.Items.Add(item.Name);
            }
        }
    }
}

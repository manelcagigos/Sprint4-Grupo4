
namespace Sprint4
{
    partial class FormEscanearQR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbCodiUsuari = new System.Windows.Forms.Label();
            this.tb_usercode = new System.Windows.Forms.TextBox();
            this.pictureBoxCamara = new System.Windows.Forms.PictureBox();
            this.tbMultilinea = new System.Windows.Forms.TextBox();
            this.btValidarQR = new System.Windows.Forms.Button();
            this.lbNomUsuari = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btPrubeas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodiUsuari
            // 
            this.lbCodiUsuari.AutoSize = true;
            this.lbCodiUsuari.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodiUsuari.ForeColor = System.Drawing.Color.White;
            this.lbCodiUsuari.Location = new System.Drawing.Point(72, 65);
            this.lbCodiUsuari.Name = "lbCodiUsuari";
            this.lbCodiUsuari.Size = new System.Drawing.Size(153, 23);
            this.lbCodiUsuari.TabIndex = 18;
            this.lbCodiUsuari.Text = "CODI USUARI";
            // 
            // tb_usercode
            // 
            this.tb_usercode.Location = new System.Drawing.Point(248, 62);
            this.tb_usercode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_usercode.Name = "tb_usercode";
            this.tb_usercode.Size = new System.Drawing.Size(112, 26);
            this.tb_usercode.TabIndex = 19;
            // 
            // pictureBoxCamara
            // 
            this.pictureBoxCamara.Location = new System.Drawing.Point(392, 12);
            this.pictureBoxCamara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCamara.Name = "pictureBoxCamara";
            this.pictureBoxCamara.Size = new System.Drawing.Size(397, 426);
            this.pictureBoxCamara.TabIndex = 20;
            this.pictureBoxCamara.TabStop = false;
            // 
            // tbMultilinea
            // 
            this.tbMultilinea.Location = new System.Drawing.Point(76, 160);
            this.tbMultilinea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMultilinea.Multiline = true;
            this.tbMultilinea.Name = "tbMultilinea";
            this.tbMultilinea.Size = new System.Drawing.Size(283, 213);
            this.tbMultilinea.TabIndex = 21;
            // 
            // btValidarQR
            // 
            this.btValidarQR.Location = new System.Drawing.Point(138, 392);
            this.btValidarQR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btValidarQR.Name = "btValidarQR";
            this.btValidarQR.Size = new System.Drawing.Size(163, 44);
            this.btValidarQR.TabIndex = 22;
            this.btValidarQR.Text = "VALIDAR QR";
            this.btValidarQR.UseVisualStyleBackColor = true;
            this.btValidarQR.Click += new System.EventHandler(this.btValidarQR_Click);
            // 
            // lbNomUsuari
            // 
            this.lbNomUsuari.AutoSize = true;
            this.lbNomUsuari.ForeColor = System.Drawing.Color.White;
            this.lbNomUsuari.Location = new System.Drawing.Point(245, 121);
            this.lbNomUsuari.Name = "lbNomUsuari";
            this.lbNomUsuari.Size = new System.Drawing.Size(51, 20);
            this.lbNomUsuari.TabIndex = 23;
            this.lbNomUsuari.Text = "label1";
            this.lbNomUsuari.Click += new System.EventHandler(this.lbNomUsuari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "NOM COMPLERT";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 28);
            this.comboBox1.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btPrubeas
            // 
            this.btPrubeas.Location = new System.Drawing.Point(36, 392);
            this.btPrubeas.Name = "btPrubeas";
            this.btPrubeas.Size = new System.Drawing.Size(96, 57);
            this.btPrubeas.TabIndex = 26;
            this.btPrubeas.Text = "Pruebas";
            this.btPrubeas.UseVisualStyleBackColor = true;
            this.btPrubeas.Click += new System.EventHandler(this.btPrubeas_Click);
            // 
            // FormEscanearQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btPrubeas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNomUsuari);
            this.Controls.Add(this.btValidarQR);
            this.Controls.Add(this.tbMultilinea);
            this.Controls.Add(this.pictureBoxCamara);
            this.Controls.Add(this.tb_usercode);
            this.Controls.Add(this.lbCodiUsuari);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEscanearQR";
            this.Text = "FormEscanearQR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEscanearQR_FormClosing);
            this.Load += new System.EventHandler(this.FormEscanearQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodiUsuari;
        private System.Windows.Forms.TextBox tb_usercode;
        private System.Windows.Forms.PictureBox pictureBoxCamara;
        private System.Windows.Forms.TextBox tbMultilinea;
        private System.Windows.Forms.Button btValidarQR;
        private System.Windows.Forms.Label lbNomUsuari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btPrubeas;
    }
}
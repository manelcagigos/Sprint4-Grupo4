
namespace Sprint4
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmb_portsD = new System.Windows.Forms.ComboBox();
            this.btn_conn = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lb_PortsDisponibles = new System.Windows.Forms.Label();
            this.tbCodiArduino = new System.Windows.Forms.TextBox();
            this.btVerificarCodiTemporal = new System.Windows.Forms.Button();
            this.gbVerificacioCodiTemporal = new System.Windows.Forms.GroupBox();
            this.gbVerificacioCodiTemporal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.Red;
            this.lbTimer.Location = new System.Drawing.Point(12, 9);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(0, 30);
            this.lbTimer.TabIndex = 0;
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmb_portsD
            // 
            this.cmb_portsD.FormattingEnabled = true;
            this.cmb_portsD.Location = new System.Drawing.Point(95, 43);
            this.cmb_portsD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_portsD.Name = "cmb_portsD";
            this.cmb_portsD.Size = new System.Drawing.Size(314, 28);
            this.cmb_portsD.TabIndex = 2;
            this.cmb_portsD.SelectedIndexChanged += new System.EventHandler(this.cmb_portsD_SelectedIndexChanged);
            // 
            // btn_conn
            // 
            this.btn_conn.Font = new System.Drawing.Font("OCR A Extended", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conn.Location = new System.Drawing.Point(432, 25);
            this.btn_conn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(139, 46);
            this.btn_conn.TabIndex = 3;
            this.btn_conn.Text = "Connectar";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.White;
            this.lbCodigo.Location = new System.Drawing.Point(50, 40);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(179, 23);
            this.lbCodigo.TabIndex = 4;
            this.lbCodigo.Text = "CODI TEMPORAL";
            // 
            // lb_PortsDisponibles
            // 
            this.lb_PortsDisponibles.AutoSize = true;
            this.lb_PortsDisponibles.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PortsDisponibles.ForeColor = System.Drawing.Color.Silver;
            this.lb_PortsDisponibles.Location = new System.Drawing.Point(90, 9);
            this.lb_PortsDisponibles.Name = "lb_PortsDisponibles";
            this.lb_PortsDisponibles.Size = new System.Drawing.Size(319, 30);
            this.lb_PortsDisponibles.TabIndex = 5;
            this.lb_PortsDisponibles.Text = "Ports disponibles";
            // 
            // tbCodiArduino
            // 
            this.tbCodiArduino.BackColor = System.Drawing.Color.Black;
            this.tbCodiArduino.Enabled = false;
            this.tbCodiArduino.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodiArduino.ForeColor = System.Drawing.Color.White;
            this.tbCodiArduino.Location = new System.Drawing.Point(54, 76);
            this.tbCodiArduino.Name = "tbCodiArduino";
            this.tbCodiArduino.Size = new System.Drawing.Size(175, 28);
            this.tbCodiArduino.TabIndex = 6;
            // 
            // btVerificarCodiTemporal
            // 
            this.btVerificarCodiTemporal.Font = new System.Drawing.Font("OCR A Extended", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerificarCodiTemporal.ForeColor = System.Drawing.Color.Black;
            this.btVerificarCodiTemporal.Location = new System.Drawing.Point(251, 51);
            this.btVerificarCodiTemporal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btVerificarCodiTemporal.Name = "btVerificarCodiTemporal";
            this.btVerificarCodiTemporal.Size = new System.Drawing.Size(139, 46);
            this.btVerificarCodiTemporal.TabIndex = 7;
            this.btVerificarCodiTemporal.Text = "Verificar";
            this.btVerificarCodiTemporal.UseVisualStyleBackColor = true;
            this.btVerificarCodiTemporal.Click += new System.EventHandler(this.btVerificarCodiTemporal_Click);
            // 
            // gbVerificacioCodiTemporal
            // 
            this.gbVerificacioCodiTemporal.Controls.Add(this.lbCodigo);
            this.gbVerificacioCodiTemporal.Controls.Add(this.btVerificarCodiTemporal);
            this.gbVerificacioCodiTemporal.Controls.Add(this.tbCodiArduino);
            this.gbVerificacioCodiTemporal.Font = new System.Drawing.Font("OCR A Extended", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVerificacioCodiTemporal.ForeColor = System.Drawing.Color.White;
            this.gbVerificacioCodiTemporal.Location = new System.Drawing.Point(95, 96);
            this.gbVerificacioCodiTemporal.Name = "gbVerificacioCodiTemporal";
            this.gbVerificacioCodiTemporal.Size = new System.Drawing.Size(434, 136);
            this.gbVerificacioCodiTemporal.TabIndex = 8;
            this.gbVerificacioCodiTemporal.TabStop = false;
            this.gbVerificacioCodiTemporal.Text = "Primera Verificacio";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1215, 586);
            this.Controls.Add(this.gbVerificacioCodiTemporal);
            this.Controls.Add(this.lb_PortsDisponibles);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.cmb_portsD);
            this.Controls.Add(this.lbTimer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2AUTH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbVerificacioCodiTemporal.ResumeLayout(false);
            this.gbVerificacioCodiTemporal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmb_portsD;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lb_PortsDisponibles;
        private System.Windows.Forms.TextBox tbCodiArduino;
        private System.Windows.Forms.Button btVerificarCodiTemporal;
        private System.Windows.Forms.GroupBox gbVerificacioCodiTemporal;
    }
}


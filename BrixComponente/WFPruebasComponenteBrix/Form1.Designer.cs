namespace WFPruebasComponenteBrix
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.brixPanel1 = new BrixComponente.BrixPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblInformativo = new System.Windows.Forms.Label();
            this.linkbtnLabelRecordar = new System.Windows.Forms.LinkLabel();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.rbtnCateLP = new System.Windows.Forms.RadioButton();
            this.rbtnCateMDQ = new System.Windows.Forms.RadioButton();
            this.rbtnCateCA = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.brixPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // brixPanel1
            // 
            this.brixPanel1.BackColor = System.Drawing.Color.White;
            this.brixPanel1.BorderRadius = 0;
            this.brixPanel1.Controls.Add(this.pictureBox2);
            this.brixPanel1.Controls.Add(this.rbtnCateCA);
            this.brixPanel1.Controls.Add(this.rbtnCateMDQ);
            this.brixPanel1.Controls.Add(this.rbtnCateLP);
            this.brixPanel1.Controls.Add(this.lblFecha);
            this.brixPanel1.Controls.Add(this.lblPrincipal);
            this.brixPanel1.Controls.Add(this.linkbtnLabelRecordar);
            this.brixPanel1.Controls.Add(this.lblInformativo);
            this.brixPanel1.Controls.Add(this.btnSalir);
            this.brixPanel1.Controls.Add(this.btnIngresar);
            this.brixPanel1.Controls.Add(this.txtPassword);
            this.brixPanel1.Controls.Add(this.txtUsuario);
            this.brixPanel1.Controls.Add(this.pictureBox1);
            this.brixPanel1.Controls.Add(this.pictureBox3);
            this.brixPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brixPanel1.ForeColor = System.Drawing.Color.Black;
            this.brixPanel1.GradientAngle = 90F;
            this.brixPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(219)))), ((int)(((byte)(236)))));
            this.brixPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(20)))));
            this.brixPanel1.Location = new System.Drawing.Point(0, 0);
            this.brixPanel1.Name = "brixPanel1";
            this.brixPanel1.Size = new System.Drawing.Size(800, 500);
            this.brixPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUsuario.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(181, 222);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(226, 31);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPassword.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(413, 222);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(226, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(258, 340);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(148, 41);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(190)))), ((int)(((byte)(205)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(413, 340);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 41);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblInformativo
            // 
            this.lblInformativo.AutoSize = true;
            this.lblInformativo.BackColor = System.Drawing.Color.Transparent;
            this.lblInformativo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformativo.ForeColor = System.Drawing.Color.White;
            this.lblInformativo.Location = new System.Drawing.Point(241, 475);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(331, 16);
            this.lblInformativo.TabIndex = 5;
            this.lblInformativo.Text = "División Sistemas C 2023 - Todos los derechos reservcados";
            // 
            // linkbtnLabelRecordar
            // 
            this.linkbtnLabelRecordar.AutoSize = true;
            this.linkbtnLabelRecordar.BackColor = System.Drawing.Color.Transparent;
            this.linkbtnLabelRecordar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkbtnLabelRecordar.LinkColor = System.Drawing.Color.White;
            this.linkbtnLabelRecordar.Location = new System.Drawing.Point(434, 256);
            this.linkbtnLabelRecordar.Name = "linkbtnLabelRecordar";
            this.linkbtnLabelRecordar.Size = new System.Drawing.Size(205, 16);
            this.linkbtnLabelRecordar.TabIndex = 6;
            this.linkbtnLabelRecordar.TabStop = true;
            this.linkbtnLabelRecordar.Text = "¿No Recuerda Usuario o Contraseña?";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrincipal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblPrincipal.Location = new System.Drawing.Point(143, 112);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(624, 32);
            this.lblPrincipal.TabIndex = 7;
            this.lblPrincipal.Text = "SISTEMA DE GESTIÓN DE EXPEDIENTES 2023";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(585, 154);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(182, 15);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Jueves, 13 de Abril de 2023";
            // 
            // rbtnCateLP
            // 
            this.rbtnCateLP.AutoSize = true;
            this.rbtnCateLP.BackColor = System.Drawing.Color.Transparent;
            this.rbtnCateLP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCateLP.ForeColor = System.Drawing.Color.White;
            this.rbtnCateLP.Location = new System.Drawing.Point(216, 288);
            this.rbtnCateLP.Name = "rbtnCateLP";
            this.rbtnCateLP.Size = new System.Drawing.Size(109, 28);
            this.rbtnCateLP.TabIndex = 9;
            this.rbtnCateLP.TabStop = true;
            this.rbtnCateLP.Text = "La Plata";
            this.rbtnCateLP.UseVisualStyleBackColor = false;
            // 
            // rbtnCateMDQ
            // 
            this.rbtnCateMDQ.AutoSize = true;
            this.rbtnCateMDQ.BackColor = System.Drawing.Color.Transparent;
            this.rbtnCateMDQ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCateMDQ.ForeColor = System.Drawing.Color.White;
            this.rbtnCateMDQ.Location = new System.Drawing.Point(331, 288);
            this.rbtnCateMDQ.Name = "rbtnCateMDQ";
            this.rbtnCateMDQ.Size = new System.Drawing.Size(158, 28);
            this.rbtnCateMDQ.TabIndex = 10;
            this.rbtnCateMDQ.TabStop = true;
            this.rbtnCateMDQ.Text = "Mar del Plata";
            this.rbtnCateMDQ.UseVisualStyleBackColor = false;
            // 
            // rbtnCateCA
            // 
            this.rbtnCateCA.AutoSize = true;
            this.rbtnCateCA.BackColor = System.Drawing.Color.Transparent;
            this.rbtnCateCA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCateCA.ForeColor = System.Drawing.Color.White;
            this.rbtnCateCA.Location = new System.Drawing.Point(495, 288);
            this.rbtnCateCA.Name = "rbtnCateCA";
            this.rbtnCateCA.Size = new System.Drawing.Size(125, 28);
            this.rbtnCateCA.TabIndex = 11;
            this.rbtnCateCA.TabStop = true;
            this.rbtnCateCA.Text = "Campana";
            this.rbtnCateCA.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(316, 429);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(58, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.brixPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.brixPanel1.ResumeLayout(false);
            this.brixPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrixComponente.BrixPanel brixPanel1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.LinkLabel linkbtnLabelRecordar;
        private System.Windows.Forms.Label lblInformativo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnCateLP;
        private System.Windows.Forms.RadioButton rbtnCateCA;
        private System.Windows.Forms.RadioButton rbtnCateMDQ;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


namespace PruebaCognitec
{
    partial class Captura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Captura));
            this.botonCaptura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelEstado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreFIR = new System.Windows.Forms.TextBox();
            this.ResultadoEnroll = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultadoVerif = new System.Windows.Forms.Label();
            this.Verificar = new System.Windows.Forms.Button();
            this.nombreIdent = new System.Windows.Forms.Label();
            this.nombreId = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ErrorUsu = new System.Windows.Forms.Label();
            this.AnchoCabeza = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.textBoxCaract = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonVerify = new System.Windows.Forms.RadioButton();
            this.radioButtonEnroll = new System.Windows.Forms.RadioButton();
            this.numImag = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreMasivo = new System.Windows.Forms.TextBox();
            this.EnrollMasivoStart = new System.Windows.Forms.Button();
            this.ErrorUsu2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ojo1Y = new System.Windows.Forms.Label();
            this.ojo2Y = new System.Windows.Forms.Label();
            this.gradosOjos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonCaptura
            // 
            this.botonCaptura.Location = new System.Drawing.Point(160, 76);
            this.botonCaptura.Name = "botonCaptura";
            this.botonCaptura.Size = new System.Drawing.Size(75, 23);
            this.botonCaptura.TabIndex = 0;
            this.botonCaptura.Text = "Enroll";
            this.botonCaptura.UseVisualStyleBackColor = true;
            this.botonCaptura.Click += new System.EventHandler(this.Captura_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(132, 354);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(0, 13);
            this.labelEstado.TabIndex = 2;
            this.labelEstado.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombreFIR);
            this.groupBox1.Controls.Add(this.botonCaptura);
            this.groupBox1.Location = new System.Drawing.Point(416, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 138);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrollment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre de usuario";
            // 
            // nombreFIR
            // 
            this.nombreFIR.Location = new System.Drawing.Point(93, 50);
            this.nombreFIR.Name = "nombreFIR";
            this.nombreFIR.Size = new System.Drawing.Size(213, 20);
            this.nombreFIR.TabIndex = 38;
            // 
            // ResultadoEnroll
            // 
            this.ResultadoEnroll.AutoSize = true;
            this.ResultadoEnroll.ForeColor = System.Drawing.Color.Black;
            this.ResultadoEnroll.Location = new System.Drawing.Point(10, 164);
            this.ResultadoEnroll.Name = "ResultadoEnroll";
            this.ResultadoEnroll.Size = new System.Drawing.Size(55, 13);
            this.ResultadoEnroll.TabIndex = 45;
            this.ResultadoEnroll.Text = "Resultado";
            this.ResultadoEnroll.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultadoVerif);
            this.groupBox3.Controls.Add(this.Verificar);
            this.groupBox3.Controls.Add(this.nombreIdent);
            this.groupBox3.Controls.Add(this.nombreId);
            this.groupBox3.Location = new System.Drawing.Point(416, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 140);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Verificación";
            // 
            // ResultadoVerif
            // 
            this.ResultadoVerif.AutoSize = true;
            this.ResultadoVerif.Location = new System.Drawing.Point(148, 113);
            this.ResultadoVerif.Name = "ResultadoVerif";
            this.ResultadoVerif.Size = new System.Drawing.Size(55, 13);
            this.ResultadoVerif.TabIndex = 3;
            this.ResultadoVerif.Text = "Resultado";
            this.ResultadoVerif.Visible = false;
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(160, 78);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(75, 23);
            this.Verificar.TabIndex = 2;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // nombreIdent
            // 
            this.nombreIdent.AutoSize = true;
            this.nombreIdent.Location = new System.Drawing.Point(90, 30);
            this.nombreIdent.Name = "nombreIdent";
            this.nombreIdent.Size = new System.Drawing.Size(96, 13);
            this.nombreIdent.TabIndex = 1;
            this.nombreIdent.Text = "Nombre de usuario";
            // 
            // nombreId
            // 
            this.nombreId.Location = new System.Drawing.Point(90, 52);
            this.nombreId.Name = "nombreId";
            this.nombreId.Size = new System.Drawing.Size(223, 20);
            this.nombreId.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ErrorUsu
            // 
            this.ErrorUsu.AutoSize = true;
            this.ErrorUsu.ForeColor = System.Drawing.Color.Red;
            this.ErrorUsu.Location = new System.Drawing.Point(525, 202);
            this.ErrorUsu.Name = "ErrorUsu";
            this.ErrorUsu.Size = new System.Drawing.Size(162, 13);
            this.ErrorUsu.TabIndex = 47;
            this.ErrorUsu.Text = "Introduzca un nombre de usuario";
            this.ErrorUsu.Visible = false;
            // 
            // AnchoCabeza
            // 
            this.AnchoCabeza.AutoSize = true;
            this.AnchoCabeza.Location = new System.Drawing.Point(506, 395);
            this.AnchoCabeza.Name = "AnchoCabeza";
            this.AnchoCabeza.Size = new System.Drawing.Size(0, 13);
            this.AnchoCabeza.TabIndex = 48;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(730, 400);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 49;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // textBoxCaract
            // 
            this.textBoxCaract.Location = new System.Drawing.Point(911, 305);
            this.textBoxCaract.Multiline = true;
            this.textBoxCaract.Name = "textBoxCaract";
            this.textBoxCaract.Size = new System.Drawing.Size(141, 113);
            this.textBoxCaract.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(935, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Características";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonVerify);
            this.groupBox2.Controls.Add(this.radioButtonEnroll);
            this.groupBox2.Controls.Add(this.ResultadoEnroll);
            this.groupBox2.Controls.Add(this.numImag);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nombreMasivo);
            this.groupBox2.Controls.Add(this.EnrollMasivoStart);
            this.groupBox2.Location = new System.Drawing.Point(856, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 191);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reconocimiento Masivo";
            // 
            // radioButtonVerify
            // 
            this.radioButtonVerify.AutoSize = true;
            this.radioButtonVerify.Location = new System.Drawing.Point(138, 121);
            this.radioButtonVerify.Name = "radioButtonVerify";
            this.radioButtonVerify.Size = new System.Drawing.Size(51, 17);
            this.radioButtonVerify.TabIndex = 49;
            this.radioButtonVerify.TabStop = true;
            this.radioButtonVerify.Text = "Verify";
            this.radioButtonVerify.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnroll
            // 
            this.radioButtonEnroll.AutoSize = true;
            this.radioButtonEnroll.Checked = true;
            this.radioButtonEnroll.Location = new System.Drawing.Point(55, 121);
            this.radioButtonEnroll.Name = "radioButtonEnroll";
            this.radioButtonEnroll.Size = new System.Drawing.Size(51, 17);
            this.radioButtonEnroll.TabIndex = 48;
            this.radioButtonEnroll.TabStop = true;
            this.radioButtonEnroll.Text = "Enroll";
            this.radioButtonEnroll.UseVisualStyleBackColor = true;
            // 
            // numImag
            // 
            this.numImag.AutoSize = true;
            this.numImag.Location = new System.Drawing.Point(209, 164);
            this.numImag.Name = "numImag";
            this.numImag.Size = new System.Drawing.Size(17, 13);
            this.numImag.TabIndex = 47;
            this.numImag.Text = "nº";
            this.numImag.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nombre de usuario";
            // 
            // nombreMasivo
            // 
            this.nombreMasivo.Location = new System.Drawing.Point(13, 60);
            this.nombreMasivo.Name = "nombreMasivo";
            this.nombreMasivo.Size = new System.Drawing.Size(213, 20);
            this.nombreMasivo.TabIndex = 38;
            // 
            // EnrollMasivoStart
            // 
            this.EnrollMasivoStart.Location = new System.Drawing.Point(82, 86);
            this.EnrollMasivoStart.Name = "EnrollMasivoStart";
            this.EnrollMasivoStart.Size = new System.Drawing.Size(75, 23);
            this.EnrollMasivoStart.TabIndex = 0;
            this.EnrollMasivoStart.Text = "Start";
            this.EnrollMasivoStart.UseVisualStyleBackColor = true;
            this.EnrollMasivoStart.Click += new System.EventHandler(this.EnrollMasivoStart_Click);
            // 
            // ErrorUsu2
            // 
            this.ErrorUsu2.AutoSize = true;
            this.ErrorUsu2.ForeColor = System.Drawing.Color.Red;
            this.ErrorUsu2.Location = new System.Drawing.Point(901, 257);
            this.ErrorUsu2.Name = "ErrorUsu2";
            this.ErrorUsu2.Size = new System.Drawing.Size(162, 13);
            this.ErrorUsu2.TabIndex = 52;
            this.ErrorUsu2.Text = "Introduzca un nombre de usuario";
            this.ErrorUsu2.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 40;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // ojo1Y
            // 
            this.ojo1Y.AutoSize = true;
            this.ojo1Y.Location = new System.Drawing.Point(49, 367);
            this.ojo1Y.Name = "ojo1Y";
            this.ojo1Y.Size = new System.Drawing.Size(35, 13);
            this.ojo1Y.TabIndex = 53;
            this.ojo1Y.Text = "label3";
            this.ojo1Y.Visible = false;
            // 
            // ojo2Y
            // 
            this.ojo2Y.AutoSize = true;
            this.ojo2Y.Location = new System.Drawing.Point(227, 367);
            this.ojo2Y.Name = "ojo2Y";
            this.ojo2Y.Size = new System.Drawing.Size(35, 13);
            this.ojo2Y.TabIndex = 54;
            this.ojo2Y.Text = "label5";
            this.ojo2Y.Visible = false;
            // 
            // gradosOjos
            // 
            this.gradosOjos.AutoSize = true;
            this.gradosOjos.Location = new System.Drawing.Point(135, 404);
            this.gradosOjos.Name = "gradosOjos";
            this.gradosOjos.Size = new System.Drawing.Size(35, 13);
            this.gradosOjos.TabIndex = 55;
            this.gradosOjos.Text = "label3";
            this.gradosOjos.Visible = false;
            // 
            // Captura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 435);
            this.Controls.Add(this.gradosOjos);
            this.Controls.Add(this.ojo2Y);
            this.Controls.Add(this.ojo1Y);
            this.Controls.Add(this.ErrorUsu2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCaract);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.AnchoCabeza);
            this.Controls.Add(this.ErrorUsu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Captura";
            this.Text = "Captura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCaptura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreFIR;
        private System.Windows.Forms.Label ResultadoEnroll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ResultadoVerif;
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.Label nombreIdent;
        private System.Windows.Forms.TextBox nombreId;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label ErrorUsu;
        private System.Windows.Forms.Label AnchoCabeza;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox textBoxCaract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreMasivo;
        private System.Windows.Forms.Button EnrollMasivoStart;
        private System.Windows.Forms.Label ErrorUsu2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label numImag;
        private System.Windows.Forms.RadioButton radioButtonVerify;
        private System.Windows.Forms.RadioButton radioButtonEnroll;
        private System.Windows.Forms.Label ojo1Y;
        private System.Windows.Forms.Label ojo2Y;
        private System.Windows.Forms.Label gradosOjos;
    }
}
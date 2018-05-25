namespace PruebaCognitec
{
    partial class EnrollIdenVerif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollIdenVerif));
            this.OkIdent = new System.Windows.Forms.Label();
            this.identificationFace = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreFIR = new System.Windows.Forms.TextBox();
            this.OkEnroll = new System.Windows.Forms.Label();
            this.FIRconvert = new System.Windows.Forms.Button();
            this.CargarImagen = new System.Windows.Forms.Button();
            this.ImagenCara = new System.Windows.Forms.PictureBox();
            this.Imagen = new System.Windows.Forms.GroupBox();
            this.MasDeUnaCara = new System.Windows.Forms.Label();
            this.pathSeleccionar = new System.Windows.Forms.Label();
            this.directorio = new System.Windows.Forms.TextBox();
            this.rutaCarpeta = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Matches = new System.Windows.Forms.TextBox();
            this.selectDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.directorioFIR = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.Verificar = new System.Windows.Forms.Button();
            this.nombreIdent = new System.Windows.Forms.Label();
            this.nombreId = new System.Windows.Forms.TextBox();
            this.cambioForm1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCara)).BeginInit();
            this.Imagen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkIdent
            // 
            this.OkIdent.AutoSize = true;
            this.OkIdent.Location = new System.Drawing.Point(348, 42);
            this.OkIdent.Name = "OkIdent";
            this.OkIdent.Size = new System.Drawing.Size(21, 13);
            this.OkIdent.TabIndex = 42;
            this.OkIdent.Text = "Ok";
            this.OkIdent.Visible = false;
            // 
            // identificationFace
            // 
            this.identificationFace.Location = new System.Drawing.Point(262, 37);
            this.identificationFace.Name = "identificationFace";
            this.identificationFace.Size = new System.Drawing.Size(80, 23);
            this.identificationFace.TabIndex = 41;
            this.identificationFace.Text = "Identificar";
            this.identificationFace.UseVisualStyleBackColor = true;
            this.identificationFace.Click += new System.EventHandler(this.identificationFace_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = ".fir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre fichero de enrollment";
            // 
            // nombreFIR
            // 
            this.nombreFIR.Location = new System.Drawing.Point(93, 50);
            this.nombreFIR.Name = "nombreFIR";
            this.nombreFIR.Size = new System.Drawing.Size(213, 20);
            this.nombreFIR.TabIndex = 38;
            this.nombreFIR.Text = "prueba";
            // 
            // OkEnroll
            // 
            this.OkEnroll.AutoSize = true;
            this.OkEnroll.Location = new System.Drawing.Point(254, 81);
            this.OkEnroll.Name = "OkEnroll";
            this.OkEnroll.Size = new System.Drawing.Size(21, 13);
            this.OkEnroll.TabIndex = 37;
            this.OkEnroll.Text = "Ok";
            this.OkEnroll.Visible = false;
            // 
            // FIRconvert
            // 
            this.FIRconvert.Location = new System.Drawing.Point(149, 76);
            this.FIRconvert.Name = "FIRconvert";
            this.FIRconvert.Size = new System.Drawing.Size(99, 23);
            this.FIRconvert.TabIndex = 36;
            this.FIRconvert.Text = "Crear FIR";
            this.FIRconvert.UseVisualStyleBackColor = true;
            this.FIRconvert.Click += new System.EventHandler(this.FIRconvert_Click);
            // 
            // CargarImagen
            // 
            this.CargarImagen.Location = new System.Drawing.Point(168, 363);
            this.CargarImagen.Name = "CargarImagen";
            this.CargarImagen.Size = new System.Drawing.Size(87, 23);
            this.CargarImagen.TabIndex = 35;
            this.CargarImagen.Text = "Cargar Imagen";
            this.CargarImagen.UseVisualStyleBackColor = true;
            this.CargarImagen.Click += new System.EventHandler(this.CargarImagen_Click);
            // 
            // ImagenCara
            // 
            this.ImagenCara.Image = ((System.Drawing.Image)(resources.GetObject("ImagenCara.Image")));
            this.ImagenCara.Location = new System.Drawing.Point(66, 41);
            this.ImagenCara.Name = "ImagenCara";
            this.ImagenCara.Size = new System.Drawing.Size(249, 224);
            this.ImagenCara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenCara.TabIndex = 34;
            this.ImagenCara.TabStop = false;
            // 
            // Imagen
            // 
            this.Imagen.Controls.Add(this.MasDeUnaCara);
            this.Imagen.Controls.Add(this.pathSeleccionar);
            this.Imagen.Controls.Add(this.directorio);
            this.Imagen.Controls.Add(this.rutaCarpeta);
            this.Imagen.Controls.Add(this.label9);
            this.Imagen.Controls.Add(this.ImagenCara);
            this.Imagen.Location = new System.Drawing.Point(12, 12);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(396, 345);
            this.Imagen.TabIndex = 33;
            this.Imagen.TabStop = false;
            this.Imagen.Text = "Imagen";
            // 
            // MasDeUnaCara
            // 
            this.MasDeUnaCara.AutoSize = true;
            this.MasDeUnaCara.ForeColor = System.Drawing.Color.Red;
            this.MasDeUnaCara.Location = new System.Drawing.Point(202, 281);
            this.MasDeUnaCara.Name = "MasDeUnaCara";
            this.MasDeUnaCara.Size = new System.Drawing.Size(99, 13);
            this.MasDeUnaCara.TabIndex = 47;
            this.MasDeUnaCara.Text = "¡¡Más de una cara!!";
            this.MasDeUnaCara.Visible = false;
            // 
            // pathSeleccionar
            // 
            this.pathSeleccionar.AutoSize = true;
            this.pathSeleccionar.Location = new System.Drawing.Point(17, 296);
            this.pathSeleccionar.Name = "pathSeleccionar";
            this.pathSeleccionar.Size = new System.Drawing.Size(151, 13);
            this.pathSeleccionar.TabIndex = 25;
            this.pathSeleccionar.Text = "1. Seleccione la imagen facial \r\n";
            // 
            // directorio
            // 
            this.directorio.Location = new System.Drawing.Point(17, 312);
            this.directorio.Name = "directorio";
            this.directorio.Size = new System.Drawing.Size(320, 20);
            this.directorio.TabIndex = 24;
            // 
            // rutaCarpeta
            // 
            this.rutaCarpeta.Location = new System.Drawing.Point(343, 310);
            this.rutaCarpeta.Name = "rutaCarpeta";
            this.rutaCarpeta.Size = new System.Drawing.Size(27, 23);
            this.rutaCarpeta.TabIndex = 23;
            this.rutaCarpeta.Text = "...";
            this.rutaCarpeta.UseVisualStyleBackColor = true;
            this.rutaCarpeta.Click += new System.EventHandler(this.rutaCarpeta_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nombreFIR);
            this.groupBox1.Controls.Add(this.FIRconvert);
            this.groupBox1.Controls.Add(this.OkEnroll);
            this.groupBox1.Location = new System.Drawing.Point(484, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 118);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrollment";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Matches);
            this.groupBox2.Controls.Add(this.identificationFace);
            this.groupBox2.Controls.Add(this.OkIdent);
            this.groupBox2.Location = new System.Drawing.Point(484, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 157);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identificación";
            // 
            // Matches
            // 
            this.Matches.Location = new System.Drawing.Point(56, 66);
            this.Matches.Multiline = true;
            this.Matches.Name = "Matches";
            this.Matches.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Matches.Size = new System.Drawing.Size(286, 66);
            this.Matches.TabIndex = 45;
            // 
            // selectDir
            // 
            this.selectDir.Location = new System.Drawing.Point(348, 453);
            this.selectDir.Name = "selectDir";
            this.selectDir.Size = new System.Drawing.Size(35, 23);
            this.selectDir.TabIndex = 2;
            this.selectDir.Text = "...";
            this.selectDir.UseVisualStyleBackColor = true;
            this.selectDir.Click += new System.EventHandler(this.selectDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directorio de FIRs";
            // 
            // directorioFIR
            // 
            this.directorioFIR.Location = new System.Drawing.Point(52, 456);
            this.directorioFIR.Name = "directorioFIR";
            this.directorioFIR.Size = new System.Drawing.Size(290, 20);
            this.directorioFIR.TabIndex = 0;
            this.directorioFIR.Text = "D:\\ramón\\GUTI\\PruebaCognitec\\fir";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Resultado);
            this.groupBox3.Controls.Add(this.Verificar);
            this.groupBox3.Controls.Add(this.nombreIdent);
            this.groupBox3.Controls.Add(this.nombreId);
            this.groupBox3.Location = new System.Drawing.Point(484, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 140);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Verificación";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(90, 99);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(55, 13);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "Resultado";
            this.Resultado.Visible = false;
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(238, 78);
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
            // cambioForm1
            // 
            this.cambioForm1.Location = new System.Drawing.Point(730, 513);
            this.cambioForm1.Name = "cambioForm1";
            this.cambioForm1.Size = new System.Drawing.Size(143, 23);
            this.cambioForm1.TabIndex = 46;
            this.cambioForm1.Text = "Captura";
            this.cambioForm1.UseVisualStyleBackColor = true;
            this.cambioForm1.Click += new System.EventHandler(this.cambioForm1_Click);
            // 
            // EnrollIdenVerif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 553);
            this.Controls.Add(this.cambioForm1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.selectDir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directorioFIR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CargarImagen);
            this.Controls.Add(this.Imagen);
            this.Name = "EnrollIdenVerif";
            this.Text = "Enroll, Identificación y Verificación";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCara)).EndInit();
            this.Imagen.ResumeLayout(false);
            this.Imagen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OkIdent;
        private System.Windows.Forms.Button identificationFace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreFIR;
        private System.Windows.Forms.Label OkEnroll;
        private System.Windows.Forms.Button FIRconvert;
        private System.Windows.Forms.Button CargarImagen;
        private System.Windows.Forms.PictureBox ImagenCara;
        private System.Windows.Forms.GroupBox Imagen;
        private System.Windows.Forms.Label pathSeleccionar;
        private System.Windows.Forms.TextBox directorio;
        private System.Windows.Forms.Button rutaCarpeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directorioFIR;
        private System.Windows.Forms.Button selectDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox Matches;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label nombreIdent;
        private System.Windows.Forms.TextBox nombreId;
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button cambioForm1;
        private System.Windows.Forms.Label MasDeUnaCara;
    }
}
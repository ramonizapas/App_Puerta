namespace PruebaCognitec
{
    partial class Caracteristicas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caracteristicas));
            this.numCaras = new System.Windows.Forms.Label();
            this.localizacionCara = new System.Windows.Forms.Label();
            this.Iniciar = new System.Windows.Forms.Button();
            this.localizacionOjos = new System.Windows.Forms.Label();
            this.portraitCar1 = new System.Windows.Forms.Label();
            this.portraitCar2 = new System.Windows.Forms.Label();
            this.portraitCar3 = new System.Windows.Forms.Label();
            this.portraitCar4 = new System.Windows.Forms.Label();
            this.gafas = new System.Windows.Forms.Label();
            this.Cara = new System.Windows.Forms.GroupBox();
            this.Ojos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ISO = new System.Windows.Forms.GroupBox();
            this.CumpleISO = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ISOerr = new System.Windows.Forms.TextBox();
            this.Imagen = new System.Windows.Forms.GroupBox();
            this.pathSeleccionar = new System.Windows.Forms.Label();
            this.directorio = new System.Windows.Forms.TextBox();
            this.rutaCarpeta = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ImagenCara = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CargarImagen = new System.Windows.Forms.Button();
            this.cambioForm2 = new System.Windows.Forms.Button();
            this.Cara.SuspendLayout();
            this.Ojos.SuspendLayout();
            this.ISO.SuspendLayout();
            this.Imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCara)).BeginInit();
            this.SuspendLayout();
            // 
            // numCaras
            // 
            this.numCaras.AutoSize = true;
            this.numCaras.Location = new System.Drawing.Point(41, 30);
            this.numCaras.Name = "numCaras";
            this.numCaras.Size = new System.Drawing.Size(0, 13);
            this.numCaras.TabIndex = 2;
            // 
            // localizacionCara
            // 
            this.localizacionCara.AutoSize = true;
            this.localizacionCara.Location = new System.Drawing.Point(41, 75);
            this.localizacionCara.Name = "localizacionCara";
            this.localizacionCara.Size = new System.Drawing.Size(0, 13);
            this.localizacionCara.TabIndex = 3;
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(1003, 375);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(108, 23);
            this.Iniciar.TabIndex = 4;
            this.Iniciar.Text = "Iniciar análisis";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // localizacionOjos
            // 
            this.localizacionOjos.AutoSize = true;
            this.localizacionOjos.Location = new System.Drawing.Point(41, 118);
            this.localizacionOjos.Name = "localizacionOjos";
            this.localizacionOjos.Size = new System.Drawing.Size(0, 13);
            this.localizacionOjos.TabIndex = 5;
            // 
            // portraitCar1
            // 
            this.portraitCar1.AutoSize = true;
            this.portraitCar1.Location = new System.Drawing.Point(27, 33);
            this.portraitCar1.Name = "portraitCar1";
            this.portraitCar1.Size = new System.Drawing.Size(0, 13);
            this.portraitCar1.TabIndex = 6;
            // 
            // portraitCar2
            // 
            this.portraitCar2.AutoSize = true;
            this.portraitCar2.Location = new System.Drawing.Point(27, 79);
            this.portraitCar2.Name = "portraitCar2";
            this.portraitCar2.Size = new System.Drawing.Size(0, 13);
            this.portraitCar2.TabIndex = 7;
            // 
            // portraitCar3
            // 
            this.portraitCar3.AutoSize = true;
            this.portraitCar3.Location = new System.Drawing.Point(27, 122);
            this.portraitCar3.Name = "portraitCar3";
            this.portraitCar3.Size = new System.Drawing.Size(0, 13);
            this.portraitCar3.TabIndex = 8;
            // 
            // portraitCar4
            // 
            this.portraitCar4.AutoSize = true;
            this.portraitCar4.Location = new System.Drawing.Point(30, 165);
            this.portraitCar4.Name = "portraitCar4";
            this.portraitCar4.Size = new System.Drawing.Size(0, 13);
            this.portraitCar4.TabIndex = 9;
            // 
            // gafas
            // 
            this.gafas.AutoSize = true;
            this.gafas.Location = new System.Drawing.Point(30, 206);
            this.gafas.Name = "gafas";
            this.gafas.Size = new System.Drawing.Size(0, 13);
            this.gafas.TabIndex = 10;
            // 
            // Cara
            // 
            this.Cara.Controls.Add(this.numCaras);
            this.Cara.Controls.Add(this.localizacionCara);
            this.Cara.Controls.Add(this.localizacionOjos);
            this.Cara.Location = new System.Drawing.Point(13, 14);
            this.Cara.Name = "Cara";
            this.Cara.Size = new System.Drawing.Size(667, 158);
            this.Cara.TabIndex = 11;
            this.Cara.TabStop = false;
            this.Cara.Text = "Cara";
            // 
            // Ojos
            // 
            this.Ojos.Controls.Add(this.portraitCar4);
            this.Ojos.Controls.Add(this.portraitCar1);
            this.Ojos.Controls.Add(this.gafas);
            this.Ojos.Controls.Add(this.portraitCar2);
            this.Ojos.Controls.Add(this.portraitCar3);
            this.Ojos.Location = new System.Drawing.Point(293, 187);
            this.Ojos.Name = "Ojos";
            this.Ojos.Size = new System.Drawing.Size(287, 304);
            this.Ojos.TabIndex = 12;
            this.Ojos.TabStop = false;
            this.Ojos.Text = "Ojos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // ISO
            // 
            this.ISO.Controls.Add(this.CumpleISO);
            this.ISO.Controls.Add(this.label10);
            this.ISO.Controls.Add(this.ISOerr);
            this.ISO.Controls.Add(this.label1);
            this.ISO.Location = new System.Drawing.Point(12, 187);
            this.ISO.Name = "ISO";
            this.ISO.Size = new System.Drawing.Size(265, 304);
            this.ISO.TabIndex = 21;
            this.ISO.TabStop = false;
            this.ISO.Text = "ISO 19794-5";
            // 
            // CumpleISO
            // 
            this.CumpleISO.AutoSize = true;
            this.CumpleISO.Location = new System.Drawing.Point(17, 261);
            this.CumpleISO.Name = "CumpleISO";
            this.CumpleISO.Size = new System.Drawing.Size(63, 13);
            this.CumpleISO.TabIndex = 23;
            this.CumpleISO.Text = "Cumple ISO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Errores ISO 19794-5";
            // 
            // ISOerr
            // 
            this.ISOerr.AcceptsReturn = true;
            this.ISOerr.AcceptsTab = true;
            this.ISOerr.Location = new System.Drawing.Point(20, 60);
            this.ISOerr.Multiline = true;
            this.ISOerr.Name = "ISOerr";
            this.ISOerr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ISOerr.Size = new System.Drawing.Size(222, 189);
            this.ISOerr.TabIndex = 21;
            this.ISOerr.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r" +
                "\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // Imagen
            // 
            this.Imagen.Controls.Add(this.pathSeleccionar);
            this.Imagen.Controls.Add(this.directorio);
            this.Imagen.Controls.Add(this.rutaCarpeta);
            this.Imagen.Controls.Add(this.label9);
            this.Imagen.Controls.Add(this.ImagenCara);
            this.Imagen.Location = new System.Drawing.Point(715, 14);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(396, 355);
            this.Imagen.TabIndex = 22;
            this.Imagen.TabStop = false;
            this.Imagen.Text = "Imagen";
            // 
            // pathSeleccionar
            // 
            this.pathSeleccionar.AutoSize = true;
            this.pathSeleccionar.Location = new System.Drawing.Point(23, 305);
            this.pathSeleccionar.Name = "pathSeleccionar";
            this.pathSeleccionar.Size = new System.Drawing.Size(151, 13);
            this.pathSeleccionar.TabIndex = 25;
            this.pathSeleccionar.Text = "1. Seleccione la imagen facial \r\n";
            // 
            // directorio
            // 
            this.directorio.Location = new System.Drawing.Point(23, 321);
            this.directorio.Name = "directorio";
            this.directorio.Size = new System.Drawing.Size(320, 20);
            this.directorio.TabIndex = 24;
            // 
            // rutaCarpeta
            // 
            this.rutaCarpeta.Location = new System.Drawing.Point(349, 319);
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
            this.label9.Location = new System.Drawing.Point(127, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 22;
            // 
            // ImagenCara
            // 
            this.ImagenCara.Image = ((System.Drawing.Image)(resources.GetObject("ImagenCara.Image")));
            this.ImagenCara.Location = new System.Drawing.Point(73, 51);
            this.ImagenCara.Name = "ImagenCara";
            this.ImagenCara.Size = new System.Drawing.Size(249, 224);
            this.ImagenCara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenCara.TabIndex = 23;
            this.ImagenCara.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CargarImagen
            // 
            this.CargarImagen.Location = new System.Drawing.Point(901, 375);
            this.CargarImagen.Name = "CargarImagen";
            this.CargarImagen.Size = new System.Drawing.Size(87, 23);
            this.CargarImagen.TabIndex = 24;
            this.CargarImagen.Text = "Cargar Imagen";
            this.CargarImagen.UseVisualStyleBackColor = true;
            this.CargarImagen.Click += new System.EventHandler(this.CargarImagen_Click);
            // 
            // cambioForm2
            // 
            this.cambioForm2.Location = new System.Drawing.Point(932, 492);
            this.cambioForm2.Name = "cambioForm2";
            this.cambioForm2.Size = new System.Drawing.Size(179, 23);
            this.cambioForm2.TabIndex = 25;
            this.cambioForm2.Text = "Enroll, Identificación y Verificación";
            this.cambioForm2.UseVisualStyleBackColor = true;
            this.cambioForm2.Click += new System.EventHandler(this.cambioForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 527);
            this.Controls.Add(this.cambioForm2);
            this.Controls.Add(this.CargarImagen);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.ISO);
            this.Controls.Add(this.Ojos);
            this.Controls.Add(this.Cara);
            this.Controls.Add(this.Iniciar);
            this.Name = "Form1";
            this.Text = "Características ISO";
            this.Cara.ResumeLayout(false);
            this.Cara.PerformLayout();
            this.Ojos.ResumeLayout(false);
            this.Ojos.PerformLayout();
            this.ISO.ResumeLayout(false);
            this.ISO.PerformLayout();
            this.Imagen.ResumeLayout(false);
            this.Imagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numCaras;
        private System.Windows.Forms.Label localizacionCara;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Label localizacionOjos;
        private System.Windows.Forms.Label portraitCar1;
        private System.Windows.Forms.Label portraitCar2;
        private System.Windows.Forms.Label portraitCar3;
        private System.Windows.Forms.Label portraitCar4;
        private System.Windows.Forms.Label gafas;
        private System.Windows.Forms.GroupBox Cara;
        private System.Windows.Forms.GroupBox Ojos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ISO;
        private System.Windows.Forms.GroupBox Imagen;
        private System.Windows.Forms.Label pathSeleccionar;
        private System.Windows.Forms.TextBox directorio;
        private System.Windows.Forms.Button rutaCarpeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox ImagenCara;
        private System.Windows.Forms.Button CargarImagen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ISOerr;
        private System.Windows.Forms.Label CumpleISO;
        private System.Windows.Forms.Button cambioForm2;
    }
}


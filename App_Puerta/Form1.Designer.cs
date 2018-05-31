using System;
using System.Windows.Forms;
using AxAXISMEDIACONTROLLib;

namespace App_Puerta
{
    partial class App_Puerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App_Puerta));
            this.Controles = new System.Windows.Forms.TabControl();
            this.tab_inicio = new System.Windows.Forms.TabPage();
            this.button_habilitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre_inicio = new System.Windows.Forms.TextBox();
            this.button_existente = new System.Windows.Forms.Button();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.tab_reclutamiento = new System.Windows.Forms.TabPage();
            this.panel_huella = new System.Windows.Forms.Panel();
            this.button_huella_siguiente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_borrar_huellas = new System.Windows.Forms.Button();
            this.pictureBox_huella_reclutamiento = new System.Windows.Forms.PictureBox();
            this.button_borrar_huella = new System.Windows.Forms.Button();
            this.button_huella = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label_huellas_reclutamiento = new System.Windows.Forms.Label();
            this.panel_cara = new System.Windows.Forms.Panel();
            this.axAxisMediaControl_R = new AxAXISMEDIACONTROLLib.AxAxisMediaControl();
            this.pictureBox_cara_reclutamiento = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_borrar_caras = new System.Windows.Forms.Button();
            this.button_cara = new System.Windows.Forms.Button();
            this.button_borrar_cara = new System.Windows.Forms.Button();
            this.button_final_reclutamiento = new System.Windows.Forms.Button();
            this.label_caras_reclutamiento = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_ID = new System.Windows.Forms.Panel();
            this.button_ID = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_visita1 = new System.Windows.Forms.TabPage();
            this.panel_cara_v1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.axAxisMediaControl_V1 = new AxAXISMEDIACONTROLLib.AxAxisMediaControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_borrar_cara_v1 = new System.Windows.Forms.Button();
            this.cara_result_5_v1 = new System.Windows.Forms.PictureBox();
            this.button_borrar_caras_v1 = new System.Windows.Forms.Button();
            this.label_caras_v1 = new System.Windows.Forms.Label();
            this.button_final_v1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cara_result_4_v1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cara_result_1_v1 = new System.Windows.Forms.PictureBox();
            this.cara_result_3_v1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cara_result_2_v1 = new System.Windows.Forms.PictureBox();
            this.panel_huella_v1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button_huella_siguiente_v1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_huella_v1 = new System.Windows.Forms.Button();
            this.label_huellas_v1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.huella_result_5_v1 = new System.Windows.Forms.PictureBox();
            this.button_borrar_huella_v1 = new System.Windows.Forms.Button();
            this.huella_result_4_v1 = new System.Windows.Forms.PictureBox();
            this.button_borrar_huellas_v1 = new System.Windows.Forms.Button();
            this.huella_result_3_v1 = new System.Windows.Forms.PictureBox();
            this.huella_result_1_v1 = new System.Windows.Forms.PictureBox();
            this.huella_result_2_v1 = new System.Windows.Forms.PictureBox();
            this.tab_visita2 = new System.Windows.Forms.TabPage();
            this.panel_huella_v2 = new System.Windows.Forms.Panel();
            this.button_borrar_huella_v2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.huella_result_5_v2 = new System.Windows.Forms.PictureBox();
            this.button_huella_v2 = new System.Windows.Forms.Button();
            this.huella_result_4_v2 = new System.Windows.Forms.PictureBox();
            this.button_fin = new System.Windows.Forms.Button();
            this.huella_result_3_v2 = new System.Windows.Forms.PictureBox();
            this.label_huellas_v2 = new System.Windows.Forms.Label();
            this.huella_result_2_v2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.huella_result_1_v2 = new System.Windows.Forms.PictureBox();
            this.button_borrar_huellas_v2 = new System.Windows.Forms.Button();
            this.panel_cara_v2 = new System.Windows.Forms.Panel();
            this.axAxisMediaControl_V2 = new AxAXISMEDIACONTROLLib.AxAxisMediaControl();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.button_borrar_cara_v2 = new System.Windows.Forms.Button();
            this.button_borrar_caras_v2 = new System.Windows.Forms.Button();
            this.cara_result_1_v2 = new System.Windows.Forms.PictureBox();
            this.cara_result_2_v2 = new System.Windows.Forms.PictureBox();
            this.cara_result_3_v2 = new System.Windows.Forms.PictureBox();
            this.cara_result_4_v2 = new System.Windows.Forms.PictureBox();
            this.cara_result_5_v2 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button_cara_v2 = new System.Windows.Forms.Button();
            this.label_caras_v2 = new System.Windows.Forms.Label();
            this.button_cara_siguiente_v2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.timer_cara_reclutamiento = new System.Windows.Forms.Timer(this.components);
            this.Controles.SuspendLayout();
            this.tab_inicio.SuspendLayout();
            this.tab_reclutamiento.SuspendLayout();
            this.panel_huella.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_huella_reclutamiento)).BeginInit();
            this.panel_cara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxisMediaControl_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cara_reclutamiento)).BeginInit();
            this.panel_ID.SuspendLayout();
            this.tab_visita1.SuspendLayout();
            this.panel_cara_v1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxisMediaControl_V1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_5_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_4_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_1_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_3_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_2_v1)).BeginInit();
            this.panel_huella_v1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_5_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_4_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_3_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_1_v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_2_v1)).BeginInit();
            this.tab_visita2.SuspendLayout();
            this.panel_huella_v2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_5_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_4_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_3_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_2_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_1_v2)).BeginInit();
            this.panel_cara_v2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxisMediaControl_V2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_1_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_2_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_3_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_4_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_5_v2)).BeginInit();
            this.SuspendLayout();
            // 
            // Controles
            // 
            this.Controles.Controls.Add(this.tab_inicio);
            this.Controles.Controls.Add(this.tab_reclutamiento);
            this.Controles.Controls.Add(this.tab_visita1);
            this.Controles.Controls.Add(this.tab_visita2);
            this.Controles.Location = new System.Drawing.Point(1, 1);
            this.Controles.Name = "Controles";
            this.Controles.SelectedIndex = 0;
            this.Controles.Size = new System.Drawing.Size(879, 580);
            this.Controles.TabIndex = 0;
            // 
            // tab_inicio
            // 
            this.tab_inicio.Controls.Add(this.button_habilitar);
            this.tab_inicio.Controls.Add(this.label1);
            this.tab_inicio.Controls.Add(this.textBox_nombre_inicio);
            this.tab_inicio.Controls.Add(this.button_existente);
            this.tab_inicio.Controls.Add(this.button_nuevo);
            this.tab_inicio.Location = new System.Drawing.Point(4, 22);
            this.tab_inicio.Name = "tab_inicio";
            this.tab_inicio.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inicio.Size = new System.Drawing.Size(871, 554);
            this.tab_inicio.TabIndex = 0;
            this.tab_inicio.Text = "Inicio";
            this.tab_inicio.UseVisualStyleBackColor = true;
            // 
            // button_habilitar
            // 
            this.button_habilitar.Location = new System.Drawing.Point(6, 523);
            this.button_habilitar.Name = "button_habilitar";
            this.button_habilitar.Size = new System.Drawing.Size(96, 23);
            this.button_habilitar.TabIndex = 4;
            this.button_habilitar.Text = "Habilitar todo";
            this.button_habilitar.UseVisualStyleBackColor = true;
            this.button_habilitar.Click += new System.EventHandler(this.button_habilitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI (sin letra)";
            // 
            // textBox_nombre_inicio
            // 
            this.textBox_nombre_inicio.Location = new System.Drawing.Point(459, 339);
            this.textBox_nombre_inicio.Multiline = true;
            this.textBox_nombre_inicio.Name = "textBox_nombre_inicio";
            this.textBox_nombre_inicio.Size = new System.Drawing.Size(244, 23);
            this.textBox_nombre_inicio.TabIndex = 2;
            // 
            // button_existente
            // 
            this.button_existente.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_existente.Location = new System.Drawing.Point(456, 191);
            this.button_existente.Name = "button_existente";
            this.button_existente.Size = new System.Drawing.Size(247, 116);
            this.button_existente.TabIndex = 1;
            this.button_existente.Text = "Existente";
            this.button_existente.UseVisualStyleBackColor = true;
            this.button_existente.Click += new System.EventHandler(this.button_existente_Click);
            // 
            // button_nuevo
            // 
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.Location = new System.Drawing.Point(151, 191);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(247, 116);
            this.button_nuevo.TabIndex = 0;
            this.button_nuevo.Text = "Nuevo";
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // tab_reclutamiento
            // 
            this.tab_reclutamiento.Controls.Add(this.panel_huella);
            this.tab_reclutamiento.Controls.Add(this.panel_cara);
            this.tab_reclutamiento.Controls.Add(this.panel_ID);
            this.tab_reclutamiento.Location = new System.Drawing.Point(4, 22);
            this.tab_reclutamiento.Name = "tab_reclutamiento";
            this.tab_reclutamiento.Padding = new System.Windows.Forms.Padding(3);
            this.tab_reclutamiento.Size = new System.Drawing.Size(871, 554);
            this.tab_reclutamiento.TabIndex = 1;
            this.tab_reclutamiento.Text = "Reclutamiento";
            this.tab_reclutamiento.UseVisualStyleBackColor = true;
            // 
            // panel_huella
            // 
            this.panel_huella.Controls.Add(this.button_huella_siguiente);
            this.panel_huella.Controls.Add(this.label5);
            this.panel_huella.Controls.Add(this.button_borrar_huellas);
            this.panel_huella.Controls.Add(this.pictureBox_huella_reclutamiento);
            this.panel_huella.Controls.Add(this.button_borrar_huella);
            this.panel_huella.Controls.Add(this.button_huella);
            this.panel_huella.Controls.Add(this.label9);
            this.panel_huella.Controls.Add(this.label_huellas_reclutamiento);
            this.panel_huella.Enabled = false;
            this.panel_huella.Location = new System.Drawing.Point(213, 1);
            this.panel_huella.Name = "panel_huella";
            this.panel_huella.Size = new System.Drawing.Size(320, 553);
            this.panel_huella.TabIndex = 26;
            // 
            // button_huella_siguiente
            // 
            this.button_huella_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella_siguiente.Location = new System.Drawing.Point(209, 502);
            this.button_huella_siguiente.Name = "button_huella_siguiente";
            this.button_huella_siguiente.Size = new System.Drawing.Size(83, 39);
            this.button_huella_siguiente.TabIndex = 13;
            this.button_huella_siguiente.Text = "Siguiente";
            this.button_huella_siguiente.UseVisualStyleBackColor = true;
            this.button_huella_siguiente.Click += new System.EventHandler(this.button_huella_siguiente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Huella";
            // 
            // button_borrar_huellas
            // 
            this.button_borrar_huellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huellas.Location = new System.Drawing.Point(8, 518);
            this.button_borrar_huellas.Name = "button_borrar_huellas";
            this.button_borrar_huellas.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_huellas.TabIndex = 23;
            this.button_borrar_huellas.Text = "Borrar todas";
            this.button_borrar_huellas.UseVisualStyleBackColor = true;
            // 
            // pictureBox_huella_reclutamiento
            // 
            this.pictureBox_huella_reclutamiento.Location = new System.Drawing.Point(69, 80);
            this.pictureBox_huella_reclutamiento.Name = "pictureBox_huella_reclutamiento";
            this.pictureBox_huella_reclutamiento.Size = new System.Drawing.Size(185, 243);
            this.pictureBox_huella_reclutamiento.TabIndex = 11;
            this.pictureBox_huella_reclutamiento.TabStop = false;
            // 
            // button_borrar_huella
            // 
            this.button_borrar_huella.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_huella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huella.Location = new System.Drawing.Point(8, 489);
            this.button_borrar_huella.Name = "button_borrar_huella";
            this.button_borrar_huella.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_huella.TabIndex = 21;
            this.button_borrar_huella.Text = "Borrar última";
            this.button_borrar_huella.UseVisualStyleBackColor = true;
            // 
            // button_huella
            // 
            this.button_huella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella.Location = new System.Drawing.Point(123, 344);
            this.button_huella.Name = "button_huella";
            this.button_huella.Size = new System.Drawing.Size(75, 31);
            this.button_huella.TabIndex = 12;
            this.button_huella.Text = "Captura";
            this.button_huella.UseVisualStyleBackColor = true;
            this.button_huella.Click += new System.EventHandler(this.button_huella_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(162, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "/5";
            // 
            // label_huellas_reclutamiento
            // 
            this.label_huellas_reclutamiento.AutoSize = true;
            this.label_huellas_reclutamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_huellas_reclutamiento.Location = new System.Drawing.Point(132, 378);
            this.label_huellas_reclutamiento.Name = "label_huellas_reclutamiento";
            this.label_huellas_reclutamiento.Size = new System.Drawing.Size(24, 25);
            this.label_huellas_reclutamiento.TabIndex = 17;
            this.label_huellas_reclutamiento.Text = "1";
            // 
            // panel_cara
            // 
            this.panel_cara.Controls.Add(this.axAxisMediaControl_R);
            this.panel_cara.Controls.Add(this.pictureBox_cara_reclutamiento);
            this.panel_cara.Controls.Add(this.label6);
            this.panel_cara.Controls.Add(this.button_borrar_caras);
            this.panel_cara.Controls.Add(this.button_cara);
            this.panel_cara.Controls.Add(this.button_borrar_cara);
            this.panel_cara.Controls.Add(this.button_final_reclutamiento);
            this.panel_cara.Controls.Add(this.label_caras_reclutamiento);
            this.panel_cara.Controls.Add(this.label10);
            this.panel_cara.Enabled = false;
            this.panel_cara.Location = new System.Drawing.Point(524, 0);
            this.panel_cara.Name = "panel_cara";
            this.panel_cara.Size = new System.Drawing.Size(348, 557);
            this.panel_cara.TabIndex = 27;
            // 
            // axAxisMediaControl_R
            // 
            this.axAxisMediaControl_R.Enabled = true;
            this.axAxisMediaControl_R.Location = new System.Drawing.Point(21, 103);
            this.axAxisMediaControl_R.Name = "axAxisMediaControl_R";
            this.axAxisMediaControl_R.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxisMediaControl_R.OcxState")));
            this.axAxisMediaControl_R.Size = new System.Drawing.Size(192, 192);
            this.axAxisMediaControl_R.TabIndex = 26;
            // 
            // pictureBox_cara_reclutamiento
            // 
            this.pictureBox_cara_reclutamiento.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cara_reclutamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_cara_reclutamiento.Location = new System.Drawing.Point(222, 152);
            this.pictureBox_cara_reclutamiento.Name = "pictureBox_cara_reclutamiento";
            this.pictureBox_cara_reclutamiento.Size = new System.Drawing.Size(119, 102);
            this.pictureBox_cara_reclutamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cara_reclutamiento.TabIndex = 14;
            this.pictureBox_cara_reclutamiento.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Facial";
            // 
            // button_borrar_caras
            // 
            this.button_borrar_caras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_caras.Location = new System.Drawing.Point(15, 519);
            this.button_borrar_caras.Name = "button_borrar_caras";
            this.button_borrar_caras.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_caras.TabIndex = 25;
            this.button_borrar_caras.Text = "Borrar todas";
            this.button_borrar_caras.UseVisualStyleBackColor = true;
            // 
            // button_cara
            // 
            this.button_cara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cara.Location = new System.Drawing.Point(144, 417);
            this.button_cara.Name = "button_cara";
            this.button_cara.Size = new System.Drawing.Size(75, 31);
            this.button_cara.TabIndex = 15;
            this.button_cara.Text = "Captura";
            this.button_cara.UseVisualStyleBackColor = true;
            this.button_cara.Click += new System.EventHandler(this.button_cara_Click);
            // 
            // button_borrar_cara
            // 
            this.button_borrar_cara.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_cara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_cara.Location = new System.Drawing.Point(15, 490);
            this.button_borrar_cara.Name = "button_borrar_cara";
            this.button_borrar_cara.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_cara.TabIndex = 24;
            this.button_borrar_cara.Text = "Borrar última";
            this.button_borrar_cara.UseVisualStyleBackColor = true;
            // 
            // button_final_reclutamiento
            // 
            this.button_final_reclutamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_final_reclutamiento.Location = new System.Drawing.Point(252, 503);
            this.button_final_reclutamiento.Name = "button_final_reclutamiento";
            this.button_final_reclutamiento.Size = new System.Drawing.Size(85, 39);
            this.button_final_reclutamiento.TabIndex = 16;
            this.button_final_reclutamiento.Text = "Siguiente";
            this.button_final_reclutamiento.UseVisualStyleBackColor = true;
            this.button_final_reclutamiento.Click += new System.EventHandler(this.button_final_reclutamiento_Click);
            // 
            // label_caras_reclutamiento
            // 
            this.label_caras_reclutamiento.AutoSize = true;
            this.label_caras_reclutamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_caras_reclutamiento.Location = new System.Drawing.Point(153, 451);
            this.label_caras_reclutamiento.Name = "label_caras_reclutamiento";
            this.label_caras_reclutamiento.Size = new System.Drawing.Size(24, 25);
            this.label_caras_reclutamiento.TabIndex = 18;
            this.label_caras_reclutamiento.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(183, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "/5";
            // 
            // panel_ID
            // 
            this.panel_ID.Controls.Add(this.button_ID);
            this.panel_ID.Controls.Add(this.textBox_nombre);
            this.panel_ID.Controls.Add(this.label2);
            this.panel_ID.Controls.Add(this.textBox_ID);
            this.panel_ID.Controls.Add(this.label3);
            this.panel_ID.Controls.Add(this.label4);
            this.panel_ID.Enabled = false;
            this.panel_ID.Location = new System.Drawing.Point(-1, 1);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Size = new System.Drawing.Size(216, 553);
            this.panel_ID.TabIndex = 26;
            // 
            // button_ID
            // 
            this.button_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ID.Location = new System.Drawing.Point(64, 322);
            this.button_ID.Name = "button_ID";
            this.button_ID.Size = new System.Drawing.Size(85, 32);
            this.button_ID.TabIndex = 7;
            this.button_ID.Text = "Siguiente";
            this.button_ID.UseVisualStyleBackColor = true;
            this.button_ID.Click += new System.EventHandler(this.button_ID_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(21, 167);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(168, 20);
            this.textBox_nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(21, 222);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(168, 20);
            this.textBox_ID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI sin letra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Identificación";
            // 
            // tab_visita1
            // 
            this.tab_visita1.Controls.Add(this.panel_cara_v1);
            this.tab_visita1.Controls.Add(this.panel_huella_v1);
            this.tab_visita1.Location = new System.Drawing.Point(4, 22);
            this.tab_visita1.Name = "tab_visita1";
            this.tab_visita1.Size = new System.Drawing.Size(871, 554);
            this.tab_visita1.TabIndex = 2;
            this.tab_visita1.Text = "Visita 1";
            this.tab_visita1.UseVisualStyleBackColor = true;
            // 
            // panel_cara_v1
            // 
            this.panel_cara_v1.Controls.Add(this.label15);
            this.panel_cara_v1.Controls.Add(this.axAxisMediaControl_V1);
            this.panel_cara_v1.Controls.Add(this.pictureBox1);
            this.panel_cara_v1.Controls.Add(this.button_borrar_cara_v1);
            this.panel_cara_v1.Controls.Add(this.cara_result_5_v1);
            this.panel_cara_v1.Controls.Add(this.button_borrar_caras_v1);
            this.panel_cara_v1.Controls.Add(this.label_caras_v1);
            this.panel_cara_v1.Controls.Add(this.button_final_v1);
            this.panel_cara_v1.Controls.Add(this.label8);
            this.panel_cara_v1.Controls.Add(this.cara_result_4_v1);
            this.panel_cara_v1.Controls.Add(this.label13);
            this.panel_cara_v1.Controls.Add(this.cara_result_1_v1);
            this.panel_cara_v1.Controls.Add(this.cara_result_3_v1);
            this.panel_cara_v1.Controls.Add(this.button4);
            this.panel_cara_v1.Controls.Add(this.cara_result_2_v1);
            this.panel_cara_v1.Enabled = false;
            this.panel_cara_v1.Location = new System.Drawing.Point(418, 0);
            this.panel_cara_v1.Name = "panel_cara_v1";
            this.panel_cara_v1.Size = new System.Drawing.Size(453, 554);
            this.panel_cara_v1.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "ESCENARIO 3";
            // 
            // axAxisMediaControl_V1
            // 
            this.axAxisMediaControl_V1.Enabled = true;
            this.axAxisMediaControl_V1.Location = new System.Drawing.Point(105, 80);
            this.axAxisMediaControl_V1.Name = "axAxisMediaControl_V1";
            this.axAxisMediaControl_V1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxisMediaControl_V1.OcxState")));
            this.axAxisMediaControl_V1.Size = new System.Drawing.Size(240, 320);
            this.axAxisMediaControl_V1.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(105, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 320);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // button_borrar_cara_v1
            // 
            this.button_borrar_cara_v1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_cara_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_cara_v1.Location = new System.Drawing.Point(10, 494);
            this.button_borrar_cara_v1.Name = "button_borrar_cara_v1";
            this.button_borrar_cara_v1.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_cara_v1.TabIndex = 38;
            this.button_borrar_cara_v1.Text = "Borrar última";
            this.button_borrar_cara_v1.UseVisualStyleBackColor = true;
            // 
            // cara_result_5_v1
            // 
            this.cara_result_5_v1.Location = new System.Drawing.Point(384, 313);
            this.cara_result_5_v1.Name = "cara_result_5_v1";
            this.cara_result_5_v1.Size = new System.Drawing.Size(26, 25);
            this.cara_result_5_v1.TabIndex = 49;
            this.cara_result_5_v1.TabStop = false;
            // 
            // button_borrar_caras_v1
            // 
            this.button_borrar_caras_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_caras_v1.Location = new System.Drawing.Point(10, 523);
            this.button_borrar_caras_v1.Name = "button_borrar_caras_v1";
            this.button_borrar_caras_v1.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_caras_v1.TabIndex = 39;
            this.button_borrar_caras_v1.Text = "Borrar todas";
            this.button_borrar_caras_v1.UseVisualStyleBackColor = true;
            // 
            // label_caras_v1
            // 
            this.label_caras_v1.AutoSize = true;
            this.label_caras_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_caras_v1.Location = new System.Drawing.Point(199, 463);
            this.label_caras_v1.Name = "label_caras_v1";
            this.label_caras_v1.Size = new System.Drawing.Size(24, 25);
            this.label_caras_v1.TabIndex = 36;
            this.label_caras_v1.Text = "1";
            // 
            // button_final_v1
            // 
            this.button_final_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_final_v1.Location = new System.Drawing.Point(356, 489);
            this.button_final_v1.Name = "button_final_v1";
            this.button_final_v1.Size = new System.Drawing.Size(85, 39);
            this.button_final_v1.TabIndex = 35;
            this.button_final_v1.Text = "Siguiente";
            this.button_final_v1.UseVisualStyleBackColor = true;
            this.button_final_v1.Click += new System.EventHandler(this.button_final_v1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(229, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "/5";
            // 
            // cara_result_4_v1
            // 
            this.cara_result_4_v1.Location = new System.Drawing.Point(384, 282);
            this.cara_result_4_v1.Name = "cara_result_4_v1";
            this.cara_result_4_v1.Size = new System.Drawing.Size(26, 25);
            this.cara_result_4_v1.TabIndex = 48;
            this.cara_result_4_v1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(172, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Facial";
            // 
            // cara_result_1_v1
            // 
            this.cara_result_1_v1.Location = new System.Drawing.Point(384, 189);
            this.cara_result_1_v1.Name = "cara_result_1_v1";
            this.cara_result_1_v1.Size = new System.Drawing.Size(26, 25);
            this.cara_result_1_v1.TabIndex = 45;
            this.cara_result_1_v1.TabStop = false;
            // 
            // cara_result_3_v1
            // 
            this.cara_result_3_v1.Location = new System.Drawing.Point(384, 251);
            this.cara_result_3_v1.Name = "cara_result_3_v1";
            this.cara_result_3_v1.Size = new System.Drawing.Size(26, 25);
            this.cara_result_3_v1.TabIndex = 47;
            this.cara_result_3_v1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(190, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 34;
            this.button4.Text = "Captura";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cara_result_2_v1
            // 
            this.cara_result_2_v1.Location = new System.Drawing.Point(384, 220);
            this.cara_result_2_v1.Name = "cara_result_2_v1";
            this.cara_result_2_v1.Size = new System.Drawing.Size(26, 25);
            this.cara_result_2_v1.TabIndex = 46;
            this.cara_result_2_v1.TabStop = false;
            // 
            // panel_huella_v1
            // 
            this.panel_huella_v1.Controls.Add(this.label12);
            this.panel_huella_v1.Controls.Add(this.button_huella_siguiente_v1);
            this.panel_huella_v1.Controls.Add(this.label11);
            this.panel_huella_v1.Controls.Add(this.pictureBox3);
            this.panel_huella_v1.Controls.Add(this.button_huella_v1);
            this.panel_huella_v1.Controls.Add(this.label_huellas_v1);
            this.panel_huella_v1.Controls.Add(this.label7);
            this.panel_huella_v1.Controls.Add(this.huella_result_5_v1);
            this.panel_huella_v1.Controls.Add(this.button_borrar_huella_v1);
            this.panel_huella_v1.Controls.Add(this.huella_result_4_v1);
            this.panel_huella_v1.Controls.Add(this.button_borrar_huellas_v1);
            this.panel_huella_v1.Controls.Add(this.huella_result_3_v1);
            this.panel_huella_v1.Controls.Add(this.huella_result_1_v1);
            this.panel_huella_v1.Controls.Add(this.huella_result_2_v1);
            this.panel_huella_v1.Enabled = false;
            this.panel_huella_v1.Location = new System.Drawing.Point(-2, 3);
            this.panel_huella_v1.Name = "panel_huella_v1";
            this.panel_huella_v1.Size = new System.Drawing.Size(424, 551);
            this.panel_huella_v1.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "ESCENARIO 1";
            // 
            // button_huella_siguiente_v1
            // 
            this.button_huella_siguiente_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella_siguiente_v1.Location = new System.Drawing.Point(299, 486);
            this.button_huella_siguiente_v1.Name = "button_huella_siguiente_v1";
            this.button_huella_siguiente_v1.Size = new System.Drawing.Size(83, 39);
            this.button_huella_siguiente_v1.TabIndex = 27;
            this.button_huella_siguiente_v1.Text = "Siguiente";
            this.button_huella_siguiente_v1.UseVisualStyleBackColor = true;
            this.button_huella_siguiente_v1.Click += new System.EventHandler(this.button_huella_siguiente_v1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(151, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Huella";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(121, 98);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 184);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // button_huella_v1
            // 
            this.button_huella_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella_v1.Location = new System.Drawing.Point(155, 300);
            this.button_huella_v1.Name = "button_huella_v1";
            this.button_huella_v1.Size = new System.Drawing.Size(75, 31);
            this.button_huella_v1.TabIndex = 26;
            this.button_huella_v1.Text = "Captura";
            this.button_huella_v1.UseVisualStyleBackColor = true;
            // 
            // label_huellas_v1
            // 
            this.label_huellas_v1.AutoSize = true;
            this.label_huellas_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_huellas_v1.Location = new System.Drawing.Point(164, 334);
            this.label_huellas_v1.Name = "label_huellas_v1";
            this.label_huellas_v1.Size = new System.Drawing.Size(24, 25);
            this.label_huellas_v1.TabIndex = 28;
            this.label_huellas_v1.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(194, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "/5";
            // 
            // huella_result_5_v1
            // 
            this.huella_result_5_v1.Location = new System.Drawing.Point(299, 235);
            this.huella_result_5_v1.Name = "huella_result_5_v1";
            this.huella_result_5_v1.Size = new System.Drawing.Size(26, 25);
            this.huella_result_5_v1.TabIndex = 44;
            this.huella_result_5_v1.TabStop = false;
            // 
            // button_borrar_huella_v1
            // 
            this.button_borrar_huella_v1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_huella_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huella_v1.Location = new System.Drawing.Point(12, 491);
            this.button_borrar_huella_v1.Name = "button_borrar_huella_v1";
            this.button_borrar_huella_v1.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_huella_v1.TabIndex = 30;
            this.button_borrar_huella_v1.Text = "Borrar última";
            this.button_borrar_huella_v1.UseVisualStyleBackColor = true;
            // 
            // huella_result_4_v1
            // 
            this.huella_result_4_v1.Location = new System.Drawing.Point(299, 204);
            this.huella_result_4_v1.Name = "huella_result_4_v1";
            this.huella_result_4_v1.Size = new System.Drawing.Size(26, 25);
            this.huella_result_4_v1.TabIndex = 43;
            this.huella_result_4_v1.TabStop = false;
            // 
            // button_borrar_huellas_v1
            // 
            this.button_borrar_huellas_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huellas_v1.Location = new System.Drawing.Point(12, 520);
            this.button_borrar_huellas_v1.Name = "button_borrar_huellas_v1";
            this.button_borrar_huellas_v1.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_huellas_v1.TabIndex = 31;
            this.button_borrar_huellas_v1.Text = "Borrar todas";
            this.button_borrar_huellas_v1.UseVisualStyleBackColor = true;
            // 
            // huella_result_3_v1
            // 
            this.huella_result_3_v1.Location = new System.Drawing.Point(299, 173);
            this.huella_result_3_v1.Name = "huella_result_3_v1";
            this.huella_result_3_v1.Size = new System.Drawing.Size(26, 25);
            this.huella_result_3_v1.TabIndex = 42;
            this.huella_result_3_v1.TabStop = false;
            // 
            // huella_result_1_v1
            // 
            this.huella_result_1_v1.Location = new System.Drawing.Point(299, 111);
            this.huella_result_1_v1.Name = "huella_result_1_v1";
            this.huella_result_1_v1.Size = new System.Drawing.Size(26, 25);
            this.huella_result_1_v1.TabIndex = 40;
            this.huella_result_1_v1.TabStop = false;
            // 
            // huella_result_2_v1
            // 
            this.huella_result_2_v1.Location = new System.Drawing.Point(299, 142);
            this.huella_result_2_v1.Name = "huella_result_2_v1";
            this.huella_result_2_v1.Size = new System.Drawing.Size(26, 25);
            this.huella_result_2_v1.TabIndex = 41;
            this.huella_result_2_v1.TabStop = false;
            // 
            // tab_visita2
            // 
            this.tab_visita2.Controls.Add(this.panel_huella_v2);
            this.tab_visita2.Controls.Add(this.panel_cara_v2);
            this.tab_visita2.Controls.Add(this.label16);
            this.tab_visita2.Location = new System.Drawing.Point(4, 22);
            this.tab_visita2.Name = "tab_visita2";
            this.tab_visita2.Size = new System.Drawing.Size(871, 554);
            this.tab_visita2.TabIndex = 3;
            this.tab_visita2.Text = "Visita 2";
            this.tab_visita2.UseVisualStyleBackColor = true;
            // 
            // panel_huella_v2
            // 
            this.panel_huella_v2.Controls.Add(this.button_borrar_huella_v2);
            this.panel_huella_v2.Controls.Add(this.label20);
            this.panel_huella_v2.Controls.Add(this.pictureBox8);
            this.panel_huella_v2.Controls.Add(this.huella_result_5_v2);
            this.panel_huella_v2.Controls.Add(this.button_huella_v2);
            this.panel_huella_v2.Controls.Add(this.huella_result_4_v2);
            this.panel_huella_v2.Controls.Add(this.button_fin);
            this.panel_huella_v2.Controls.Add(this.huella_result_3_v2);
            this.panel_huella_v2.Controls.Add(this.label_huellas_v2);
            this.panel_huella_v2.Controls.Add(this.huella_result_2_v2);
            this.panel_huella_v2.Controls.Add(this.label14);
            this.panel_huella_v2.Controls.Add(this.huella_result_1_v2);
            this.panel_huella_v2.Controls.Add(this.button_borrar_huellas_v2);
            this.panel_huella_v2.Enabled = false;
            this.panel_huella_v2.Location = new System.Drawing.Point(423, 2);
            this.panel_huella_v2.Name = "panel_huella_v2";
            this.panel_huella_v2.Size = new System.Drawing.Size(448, 556);
            this.panel_huella_v2.TabIndex = 64;
            // 
            // button_borrar_huella_v2
            // 
            this.button_borrar_huella_v2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_huella_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huella_v2.Location = new System.Drawing.Point(15, 492);
            this.button_borrar_huella_v2.Name = "button_borrar_huella_v2";
            this.button_borrar_huella_v2.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_huella_v2.TabIndex = 64;
            this.button_borrar_huella_v2.Text = "Borrar última";
            this.button_borrar_huella_v2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(182, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 25);
            this.label20.TabIndex = 71;
            this.label20.Text = "Huella";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(157, 113);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(143, 184);
            this.pictureBox8.TabIndex = 46;
            this.pictureBox8.TabStop = false;
            // 
            // huella_result_5_v2
            // 
            this.huella_result_5_v2.Location = new System.Drawing.Point(348, 249);
            this.huella_result_5_v2.Name = "huella_result_5_v2";
            this.huella_result_5_v2.Size = new System.Drawing.Size(26, 25);
            this.huella_result_5_v2.TabIndex = 70;
            this.huella_result_5_v2.TabStop = false;
            // 
            // button_huella_v2
            // 
            this.button_huella_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella_v2.Location = new System.Drawing.Point(191, 315);
            this.button_huella_v2.Name = "button_huella_v2";
            this.button_huella_v2.Size = new System.Drawing.Size(75, 31);
            this.button_huella_v2.TabIndex = 47;
            this.button_huella_v2.Text = "Captura";
            this.button_huella_v2.UseVisualStyleBackColor = true;
            // 
            // huella_result_4_v2
            // 
            this.huella_result_4_v2.Location = new System.Drawing.Point(348, 218);
            this.huella_result_4_v2.Name = "huella_result_4_v2";
            this.huella_result_4_v2.Size = new System.Drawing.Size(26, 25);
            this.huella_result_4_v2.TabIndex = 69;
            this.huella_result_4_v2.TabStop = false;
            // 
            // button_fin
            // 
            this.button_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fin.Location = new System.Drawing.Point(339, 505);
            this.button_fin.Name = "button_fin";
            this.button_fin.Size = new System.Drawing.Size(83, 39);
            this.button_fin.TabIndex = 48;
            this.button_fin.Text = "Siguiente";
            this.button_fin.UseVisualStyleBackColor = true;
            this.button_fin.Click += new System.EventHandler(this.button_fin_Click);
            // 
            // huella_result_3_v2
            // 
            this.huella_result_3_v2.Location = new System.Drawing.Point(348, 187);
            this.huella_result_3_v2.Name = "huella_result_3_v2";
            this.huella_result_3_v2.Size = new System.Drawing.Size(26, 25);
            this.huella_result_3_v2.TabIndex = 68;
            this.huella_result_3_v2.TabStop = false;
            // 
            // label_huellas_v2
            // 
            this.label_huellas_v2.AutoSize = true;
            this.label_huellas_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_huellas_v2.Location = new System.Drawing.Point(200, 349);
            this.label_huellas_v2.Name = "label_huellas_v2";
            this.label_huellas_v2.Size = new System.Drawing.Size(24, 25);
            this.label_huellas_v2.TabIndex = 49;
            this.label_huellas_v2.Text = "1";
            // 
            // huella_result_2_v2
            // 
            this.huella_result_2_v2.Location = new System.Drawing.Point(348, 156);
            this.huella_result_2_v2.Name = "huella_result_2_v2";
            this.huella_result_2_v2.Size = new System.Drawing.Size(26, 25);
            this.huella_result_2_v2.TabIndex = 67;
            this.huella_result_2_v2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(230, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 25);
            this.label14.TabIndex = 50;
            this.label14.Text = "/5";
            // 
            // huella_result_1_v2
            // 
            this.huella_result_1_v2.Location = new System.Drawing.Point(348, 125);
            this.huella_result_1_v2.Name = "huella_result_1_v2";
            this.huella_result_1_v2.Size = new System.Drawing.Size(26, 25);
            this.huella_result_1_v2.TabIndex = 66;
            this.huella_result_1_v2.TabStop = false;
            // 
            // button_borrar_huellas_v2
            // 
            this.button_borrar_huellas_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huellas_v2.Location = new System.Drawing.Point(15, 521);
            this.button_borrar_huellas_v2.Name = "button_borrar_huellas_v2";
            this.button_borrar_huellas_v2.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_huellas_v2.TabIndex = 65;
            this.button_borrar_huellas_v2.Text = "Borrar todas";
            this.button_borrar_huellas_v2.UseVisualStyleBackColor = true;
            // 
            // panel_cara_v2
            // 
            this.panel_cara_v2.Controls.Add(this.axAxisMediaControl_V2);
            this.panel_cara_v2.Controls.Add(this.pictureBox14);
            this.panel_cara_v2.Controls.Add(this.button_borrar_cara_v2);
            this.panel_cara_v2.Controls.Add(this.button_borrar_caras_v2);
            this.panel_cara_v2.Controls.Add(this.cara_result_1_v2);
            this.panel_cara_v2.Controls.Add(this.cara_result_2_v2);
            this.panel_cara_v2.Controls.Add(this.cara_result_3_v2);
            this.panel_cara_v2.Controls.Add(this.cara_result_4_v2);
            this.panel_cara_v2.Controls.Add(this.cara_result_5_v2);
            this.panel_cara_v2.Controls.Add(this.label19);
            this.panel_cara_v2.Controls.Add(this.label17);
            this.panel_cara_v2.Controls.Add(this.button_cara_v2);
            this.panel_cara_v2.Controls.Add(this.label_caras_v2);
            this.panel_cara_v2.Controls.Add(this.button_cara_siguiente_v2);
            this.panel_cara_v2.Enabled = false;
            this.panel_cara_v2.Location = new System.Drawing.Point(0, 0);
            this.panel_cara_v2.Name = "panel_cara_v2";
            this.panel_cara_v2.Size = new System.Drawing.Size(426, 554);
            this.panel_cara_v2.TabIndex = 72;
            // 
            // axAxisMediaControl_V2
            // 
            this.axAxisMediaControl_V2.Enabled = true;
            this.axAxisMediaControl_V2.Location = new System.Drawing.Point(80, 80);
            this.axAxisMediaControl_V2.Name = "axAxisMediaControl_V2";
            this.axAxisMediaControl_V2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxisMediaControl_V2.OcxState")));
            this.axAxisMediaControl_V2.Size = new System.Drawing.Size(240, 320);
            this.axAxisMediaControl_V2.TabIndex = 64;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(80, 80);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(240, 320);
            this.pictureBox14.TabIndex = 59;
            this.pictureBox14.TabStop = false;
            // 
            // button_borrar_cara_v2
            // 
            this.button_borrar_cara_v2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_cara_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_cara_v2.Location = new System.Drawing.Point(9, 494);
            this.button_borrar_cara_v2.Name = "button_borrar_cara_v2";
            this.button_borrar_cara_v2.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_cara_v2.TabIndex = 51;
            this.button_borrar_cara_v2.Text = "Borrar última";
            this.button_borrar_cara_v2.UseVisualStyleBackColor = true;
            // 
            // button_borrar_caras_v2
            // 
            this.button_borrar_caras_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_caras_v2.Location = new System.Drawing.Point(9, 523);
            this.button_borrar_caras_v2.Name = "button_borrar_caras_v2";
            this.button_borrar_caras_v2.Size = new System.Drawing.Size(117, 23);
            this.button_borrar_caras_v2.TabIndex = 52;
            this.button_borrar_caras_v2.Text = "Borrar todas";
            this.button_borrar_caras_v2.UseVisualStyleBackColor = true;
            // 
            // cara_result_1_v2
            // 
            this.cara_result_1_v2.Location = new System.Drawing.Point(368, 181);
            this.cara_result_1_v2.Name = "cara_result_1_v2";
            this.cara_result_1_v2.Size = new System.Drawing.Size(26, 25);
            this.cara_result_1_v2.TabIndex = 53;
            this.cara_result_1_v2.TabStop = false;
            // 
            // cara_result_2_v2
            // 
            this.cara_result_2_v2.Location = new System.Drawing.Point(368, 212);
            this.cara_result_2_v2.Name = "cara_result_2_v2";
            this.cara_result_2_v2.Size = new System.Drawing.Size(26, 25);
            this.cara_result_2_v2.TabIndex = 54;
            this.cara_result_2_v2.TabStop = false;
            // 
            // cara_result_3_v2
            // 
            this.cara_result_3_v2.Location = new System.Drawing.Point(368, 243);
            this.cara_result_3_v2.Name = "cara_result_3_v2";
            this.cara_result_3_v2.Size = new System.Drawing.Size(26, 25);
            this.cara_result_3_v2.TabIndex = 55;
            this.cara_result_3_v2.TabStop = false;
            // 
            // cara_result_4_v2
            // 
            this.cara_result_4_v2.Location = new System.Drawing.Point(368, 274);
            this.cara_result_4_v2.Name = "cara_result_4_v2";
            this.cara_result_4_v2.Size = new System.Drawing.Size(26, 25);
            this.cara_result_4_v2.TabIndex = 56;
            this.cara_result_4_v2.TabStop = false;
            // 
            // cara_result_5_v2
            // 
            this.cara_result_5_v2.Location = new System.Drawing.Point(368, 305);
            this.cara_result_5_v2.Name = "cara_result_5_v2";
            this.cara_result_5_v2.Size = new System.Drawing.Size(26, 25);
            this.cara_result_5_v2.TabIndex = 57;
            this.cara_result_5_v2.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(131, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 25);
            this.label19.TabIndex = 58;
            this.label19.Text = "Facial";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(193, 462);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 25);
            this.label17.TabIndex = 63;
            this.label17.Text = "/5";
            // 
            // button_cara_v2
            // 
            this.button_cara_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cara_v2.Location = new System.Drawing.Point(154, 428);
            this.button_cara_v2.Name = "button_cara_v2";
            this.button_cara_v2.Size = new System.Drawing.Size(75, 31);
            this.button_cara_v2.TabIndex = 60;
            this.button_cara_v2.Text = "Captura";
            this.button_cara_v2.UseVisualStyleBackColor = true;
            // 
            // label_caras_v2
            // 
            this.label_caras_v2.AutoSize = true;
            this.label_caras_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_caras_v2.Location = new System.Drawing.Point(163, 462);
            this.label_caras_v2.Name = "label_caras_v2";
            this.label_caras_v2.Size = new System.Drawing.Size(24, 25);
            this.label_caras_v2.TabIndex = 62;
            this.label_caras_v2.Text = "1";
            // 
            // button_cara_siguiente_v2
            // 
            this.button_cara_siguiente_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cara_siguiente_v2.Location = new System.Drawing.Point(309, 507);
            this.button_cara_siguiente_v2.Name = "button_cara_siguiente_v2";
            this.button_cara_siguiente_v2.Size = new System.Drawing.Size(85, 39);
            this.button_cara_siguiente_v2.TabIndex = 61;
            this.button_cara_siguiente_v2.Text = "Siguiente";
            this.button_cara_siguiente_v2.UseVisualStyleBackColor = true;
            this.button_cara_siguiente_v2.Click += new System.EventHandler(this.button_cara_siguiente_v2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(338, -49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 25);
            this.label16.TabIndex = 45;
            this.label16.Text = "Huella";
            // 
            // timer_cara_reclutamiento
            // 
            this.timer_cara_reclutamiento.Interval = 50;
            this.timer_cara_reclutamiento.Tick += new System.EventHandler(this.timer_cara_reclutamiento_Tick);
            // 
            // App_Puerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 581);
            this.Controls.Add(this.Controles);
            this.Name = "App_Puerta";
            this.Text = "App_Puerta";
            this.Controles.ResumeLayout(false);
            this.tab_inicio.ResumeLayout(false);
            this.tab_inicio.PerformLayout();
            this.tab_reclutamiento.ResumeLayout(false);
            this.panel_huella.ResumeLayout(false);
            this.panel_huella.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_huella_reclutamiento)).EndInit();
            this.panel_cara.ResumeLayout(false);
            this.panel_cara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxisMediaControl_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cara_reclutamiento)).EndInit();
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            this.tab_visita1.ResumeLayout(false);
            this.panel_cara_v1.ResumeLayout(false);
            this.panel_cara_v1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxisMediaControl_V1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_5_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_4_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_1_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_3_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_2_v1)).EndInit();
            this.panel_huella_v1.ResumeLayout(false);
            this.panel_huella_v1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_5_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_4_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_3_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_1_v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_2_v1)).EndInit();
            this.tab_visita2.ResumeLayout(false);
            this.tab_visita2.PerformLayout();
            this.panel_huella_v2.ResumeLayout(false);
            this.panel_huella_v2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_5_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_4_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_3_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_2_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huella_result_1_v2)).EndInit();
            this.panel_cara_v2.ResumeLayout(false);
            this.panel_cara_v2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxisMediaControl_V2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_1_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_2_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_3_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_4_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cara_result_5_v2)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.TabControl Controles;
        private System.Windows.Forms.TabPage tab_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre_inicio;
        private System.Windows.Forms.Button button_existente;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.TabPage tab_reclutamiento;
        private System.Windows.Forms.TabPage tab_visita1;
        private System.Windows.Forms.TabPage tab_visita2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button button_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_caras_reclutamiento;
        private System.Windows.Forms.Label label_huellas_reclutamiento;
        private System.Windows.Forms.Button button_final_reclutamiento;
        private System.Windows.Forms.Button button_cara;
        private System.Windows.Forms.PictureBox pictureBox_cara_reclutamiento;
        private System.Windows.Forms.Button button_huella_siguiente;
        private System.Windows.Forms.Button button_huella;
        private System.Windows.Forms.PictureBox pictureBox_huella_reclutamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_borrar_caras;
        private System.Windows.Forms.Button button_borrar_cara;
        private System.Windows.Forms.Button button_borrar_huellas;
        private System.Windows.Forms.Button button_borrar_huella;
        private System.Windows.Forms.Button button_borrar_huellas_v1;
        private System.Windows.Forms.Button button_borrar_huella_v1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_huellas_v1;
        private System.Windows.Forms.Button button_huella_siguiente_v1;
        private System.Windows.Forms.Button button_huella_v1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox cara_result_5_v1;
        private System.Windows.Forms.PictureBox cara_result_4_v1;
        private System.Windows.Forms.PictureBox cara_result_3_v1;
        private System.Windows.Forms.PictureBox cara_result_2_v1;
        private System.Windows.Forms.PictureBox cara_result_1_v1;
        private System.Windows.Forms.PictureBox huella_result_5_v1;
        private System.Windows.Forms.PictureBox huella_result_4_v1;
        private System.Windows.Forms.PictureBox huella_result_3_v1;
        private System.Windows.Forms.PictureBox huella_result_2_v1;
        private System.Windows.Forms.PictureBox huella_result_1_v1;
        private System.Windows.Forms.Button button_borrar_caras_v1;
        private System.Windows.Forms.Button button_borrar_cara_v1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_caras_v1;
        private System.Windows.Forms.Button button_final_v1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox huella_result_5_v2;
        private System.Windows.Forms.PictureBox huella_result_4_v2;
        private System.Windows.Forms.PictureBox huella_result_3_v2;
        private System.Windows.Forms.PictureBox huella_result_2_v2;
        private System.Windows.Forms.PictureBox huella_result_1_v2;
        private System.Windows.Forms.Button button_borrar_huellas_v2;
        private System.Windows.Forms.Button button_borrar_huella_v2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_caras_v2;
        private System.Windows.Forms.Button button_cara_siguiente_v2;
        private System.Windows.Forms.Button button_cara_v2;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox cara_result_5_v2;
        private System.Windows.Forms.PictureBox cara_result_4_v2;
        private System.Windows.Forms.PictureBox cara_result_3_v2;
        private System.Windows.Forms.PictureBox cara_result_2_v2;
        private System.Windows.Forms.PictureBox cara_result_1_v2;
        private System.Windows.Forms.Button button_borrar_caras_v2;
        private System.Windows.Forms.Button button_borrar_cara_v2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_huellas_v2;
        private System.Windows.Forms.Button button_fin;
        private System.Windows.Forms.Button button_huella_v2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel_huella;
        private System.Windows.Forms.Panel panel_cara;
        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.Panel panel_huella_v1;
        private System.Windows.Forms.Panel panel_cara_v1;
        private System.Windows.Forms.Panel panel_huella_v2;
        private System.Windows.Forms.Panel panel_cara_v2;
        private System.Windows.Forms.Button button_habilitar;
        private AxAXISMEDIACONTROLLib.AxAxisMediaControl axAxisMediaControl_R;
        private AxAXISMEDIACONTROLLib.AxAxisMediaControl axAxisMediaControl_V1;
        private AxAXISMEDIACONTROLLib.AxAxisMediaControl axAxisMediaControl_V2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private Timer timer_cara_reclutamiento;
    }
}


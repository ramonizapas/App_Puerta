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
            this.OK_tablet = new System.Windows.Forms.Label();
            this.button_tablet = new System.Windows.Forms.Button();
            this.button_IP = new System.Windows.Forms.Button();
            this.IP_label = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.button_habilitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ID_inicio = new System.Windows.Forms.TextBox();
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
            this.pictureBox_cara_v1 = new System.Windows.Forms.PictureBox();
            this.button_borrar_cara_v1 = new System.Windows.Forms.Button();
            this.button_borrar_caras_v1 = new System.Windows.Forms.Button();
            this.label_caras_V1 = new System.Windows.Forms.Label();
            this.button_final_v1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_cara_v1 = new System.Windows.Forms.Button();
            this.panel_huella_v1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button_huella_siguiente_v1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox_huella_v1 = new System.Windows.Forms.PictureBox();
            this.button_huella_v1 = new System.Windows.Forms.Button();
            this.label_huellas_V1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_borrar_huella_v1 = new System.Windows.Forms.Button();
            this.button_borrar_huellas_v1 = new System.Windows.Forms.Button();
            this.tab_visita2 = new System.Windows.Forms.TabPage();
            this.panel_huella_v2 = new System.Windows.Forms.Panel();
            this.button_borrar_huella_v2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox_huella_v2 = new System.Windows.Forms.PictureBox();
            this.button_huella_v2 = new System.Windows.Forms.Button();
            this.button_fin = new System.Windows.Forms.Button();
            this.label_huellas_V2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button_borrar_huellas_v2 = new System.Windows.Forms.Button();
            this.panel_cara_v2 = new System.Windows.Forms.Panel();
            this.axAxisMediaControl_V2 = new AxAXISMEDIACONTROLLib.AxAxisMediaControl();
            this.pictureBox_cara_v2 = new System.Windows.Forms.PictureBox();
            this.button_borrar_cara_v2 = new System.Windows.Forms.Button();
            this.button_borrar_caras_v2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button_cara_v2 = new System.Windows.Forms.Button();
            this.label_caras_V2 = new System.Windows.Forms.Label();
            this.button_cara_siguiente_v2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.timer_cara_reclutamiento = new System.Windows.Forms.Timer(this.components);
            this.timer_cara_v1 = new System.Windows.Forms.Timer(this.components);
            this.timer_cara_v2 = new System.Windows.Forms.Timer(this.components);
            this.timeOutCara_R = new System.Windows.Forms.Timer(this.components);
            this.timeOutCara_V1 = new System.Windows.Forms.Timer(this.components);
            this.timeOutCara_V2 = new System.Windows.Forms.Timer(this.components);
            this.label_busca_tablet = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cara_v1)).BeginInit();
            this.panel_huella_v1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_huella_v1)).BeginInit();
            this.tab_visita2.SuspendLayout();
            this.panel_huella_v2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_huella_v2)).BeginInit();
            this.panel_cara_v2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxisMediaControl_V2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cara_v2)).BeginInit();
            this.SuspendLayout();
            // 
            // Controles
            // 
            this.Controles.Controls.Add(this.tab_inicio);
            this.Controles.Controls.Add(this.tab_reclutamiento);
            this.Controles.Controls.Add(this.tab_visita1);
            this.Controles.Controls.Add(this.tab_visita2);
            this.Controles.Location = new System.Drawing.Point(1, 1);
            this.Controles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Controles.Name = "Controles";
            this.Controles.SelectedIndex = 0;
            this.Controles.Size = new System.Drawing.Size(1172, 714);
            this.Controles.TabIndex = 0;
            // 
            // tab_inicio
            // 
            this.tab_inicio.Controls.Add(this.label_busca_tablet);
            this.tab_inicio.Controls.Add(this.OK_tablet);
            this.tab_inicio.Controls.Add(this.button_tablet);
            this.tab_inicio.Controls.Add(this.button_IP);
            this.tab_inicio.Controls.Add(this.IP_label);
            this.tab_inicio.Controls.Add(this.textBox_IP);
            this.tab_inicio.Controls.Add(this.button_habilitar);
            this.tab_inicio.Controls.Add(this.label1);
            this.tab_inicio.Controls.Add(this.textBox_ID_inicio);
            this.tab_inicio.Controls.Add(this.button_existente);
            this.tab_inicio.Controls.Add(this.button_nuevo);
            this.tab_inicio.Location = new System.Drawing.Point(4, 25);
            this.tab_inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_inicio.Name = "tab_inicio";
            this.tab_inicio.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_inicio.Size = new System.Drawing.Size(1164, 685);
            this.tab_inicio.TabIndex = 0;
            this.tab_inicio.Text = "Inicio";
            this.tab_inicio.UseVisualStyleBackColor = true;
            // 
            // OK_tablet
            // 
            this.OK_tablet.AutoSize = true;
            this.OK_tablet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_tablet.Location = new System.Drawing.Point(459, 599);
            this.OK_tablet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OK_tablet.Name = "OK_tablet";
            this.OK_tablet.Size = new System.Drawing.Size(66, 39);
            this.OK_tablet.TabIndex = 9;
            this.OK_tablet.Text = "OK";
            this.OK_tablet.Visible = false;
            // 
            // button_tablet
            // 
            this.button_tablet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tablet.Location = new System.Drawing.Point(228, 594);
            this.button_tablet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_tablet.Name = "button_tablet";
            this.button_tablet.Size = new System.Drawing.Size(228, 48);
            this.button_tablet.TabIndex = 8;
            this.button_tablet.Text = "Buscar Tablet";
            this.button_tablet.UseVisualStyleBackColor = true;
            this.button_tablet.Click += new System.EventHandler(this.button_tablet_Click);
            // 
            // button_IP
            // 
            this.button_IP.Location = new System.Drawing.Point(945, 625);
            this.button_IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_IP.Name = "button_IP";
            this.button_IP.Size = new System.Drawing.Size(100, 28);
            this.button_IP.TabIndex = 7;
            this.button_IP.Text = "Cambiar IP";
            this.button_IP.UseVisualStyleBackColor = true;
            this.button_IP.Click += new System.EventHandler(this.button_IP_Click);
            // 
            // IP_label
            // 
            this.IP_label.AutoSize = true;
            this.IP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_label.Location = new System.Drawing.Point(603, 626);
            this.IP_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IP_label.Name = "IP_label";
            this.IP_label.Size = new System.Drawing.Size(127, 29);
            this.IP_label.TabIndex = 6;
            this.IP_label.Text = "IP_cámara";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IP.Location = new System.Drawing.Point(741, 624);
            this.textBox_IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(195, 30);
            this.textBox_IP.TabIndex = 5;
            this.textBox_IP.Text = "10.10.10.104";
            this.textBox_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_habilitar
            // 
            this.button_habilitar.Location = new System.Drawing.Point(8, 644);
            this.button_habilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_habilitar.Name = "button_habilitar";
            this.button_habilitar.Size = new System.Drawing.Size(128, 28);
            this.button_habilitar.TabIndex = 4;
            this.button_habilitar.Text = "Habilitar todo";
            this.button_habilitar.UseVisualStyleBackColor = true;
            this.button_habilitar.Click += new System.EventHandler(this.button_habilitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 398);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI (sin letra)";
            // 
            // textBox_ID_inicio
            // 
            this.textBox_ID_inicio.Location = new System.Drawing.Point(612, 417);
            this.textBox_ID_inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ID_inicio.Multiline = true;
            this.textBox_ID_inicio.Name = "textBox_ID_inicio";
            this.textBox_ID_inicio.Size = new System.Drawing.Size(324, 27);
            this.textBox_ID_inicio.TabIndex = 2;
            // 
            // button_existente
            // 
            this.button_existente.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_existente.Location = new System.Drawing.Point(608, 235);
            this.button_existente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_existente.Name = "button_existente";
            this.button_existente.Size = new System.Drawing.Size(329, 143);
            this.button_existente.TabIndex = 1;
            this.button_existente.Text = "Existente";
            this.button_existente.UseVisualStyleBackColor = true;
            this.button_existente.Click += new System.EventHandler(this.button_existente_Click);
            // 
            // button_nuevo
            // 
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.Location = new System.Drawing.Point(201, 235);
            this.button_nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(329, 143);
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
            this.tab_reclutamiento.Location = new System.Drawing.Point(4, 25);
            this.tab_reclutamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_reclutamiento.Name = "tab_reclutamiento";
            this.tab_reclutamiento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_reclutamiento.Size = new System.Drawing.Size(1164, 685);
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
            this.panel_huella.Location = new System.Drawing.Point(284, 1);
            this.panel_huella.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_huella.Name = "panel_huella";
            this.panel_huella.Size = new System.Drawing.Size(427, 681);
            this.panel_huella.TabIndex = 26;
            // 
            // button_huella_siguiente
            // 
            this.button_huella_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella_siguiente.Location = new System.Drawing.Point(279, 618);
            this.button_huella_siguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_huella_siguiente.Name = "button_huella_siguiente";
            this.button_huella_siguiente.Size = new System.Drawing.Size(111, 48);
            this.button_huella_siguiente.TabIndex = 13;
            this.button_huella_siguiente.Text = "Siguiente";
            this.button_huella_siguiente.UseVisualStyleBackColor = true;
            this.button_huella_siguiente.Click += new System.EventHandler(this.button_huella_siguiente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Huella";
            // 
            // button_borrar_huellas
            // 
            this.button_borrar_huellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huellas.Location = new System.Drawing.Point(11, 638);
            this.button_borrar_huellas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_huellas.Name = "button_borrar_huellas";
            this.button_borrar_huellas.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_huellas.TabIndex = 23;
            this.button_borrar_huellas.Text = "Borrar todas";
            this.button_borrar_huellas.UseVisualStyleBackColor = true;
            this.button_borrar_huellas.Click += new System.EventHandler(this.button_borrar_huellas_Click);
            // 
            // pictureBox_huella_reclutamiento
            // 
            this.pictureBox_huella_reclutamiento.Location = new System.Drawing.Point(92, 98);
            this.pictureBox_huella_reclutamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_huella_reclutamiento.Name = "pictureBox_huella_reclutamiento";
            this.pictureBox_huella_reclutamiento.Size = new System.Drawing.Size(247, 299);
            this.pictureBox_huella_reclutamiento.TabIndex = 11;
            this.pictureBox_huella_reclutamiento.TabStop = false;
            // 
            // button_borrar_huella
            // 
            this.button_borrar_huella.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_huella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huella.Location = new System.Drawing.Point(11, 602);
            this.button_borrar_huella.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_huella.Name = "button_borrar_huella";
            this.button_borrar_huella.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_huella.TabIndex = 21;
            this.button_borrar_huella.Text = "Borrar última";
            this.button_borrar_huella.UseVisualStyleBackColor = true;
            this.button_borrar_huella.Click += new System.EventHandler(this.button_borrar_huella_Click);
            // 
            // button_huella
            // 
            this.button_huella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella.Location = new System.Drawing.Point(164, 423);
            this.button_huella.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_huella.Name = "button_huella";
            this.button_huella.Size = new System.Drawing.Size(100, 38);
            this.button_huella.TabIndex = 12;
            this.button_huella.Text = "Captura";
            this.button_huella.UseVisualStyleBackColor = true;
            this.button_huella.Click += new System.EventHandler(this.button_huella_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(203, 465);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "/5";
            // 
            // label_huellas_reclutamiento
            // 
            this.label_huellas_reclutamiento.AutoSize = true;
            this.label_huellas_reclutamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_huellas_reclutamiento.Location = new System.Drawing.Point(180, 465);
            this.label_huellas_reclutamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_huellas_reclutamiento.Name = "label_huellas_reclutamiento";
            this.label_huellas_reclutamiento.Size = new System.Drawing.Size(29, 31);
            this.label_huellas_reclutamiento.TabIndex = 17;
            this.label_huellas_reclutamiento.Text = "0";
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
            this.panel_cara.Location = new System.Drawing.Point(699, 0);
            this.panel_cara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_cara.Name = "panel_cara";
            this.panel_cara.Size = new System.Drawing.Size(464, 686);
            this.panel_cara.TabIndex = 27;
            // 
            // axAxisMediaControl_R
            // 
            this.axAxisMediaControl_R.Enabled = true;
            this.axAxisMediaControl_R.Location = new System.Drawing.Point(21, 103);
            this.axAxisMediaControl_R.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axAxisMediaControl_R.Name = "axAxisMediaControl_R";
            this.axAxisMediaControl_R.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxisMediaControl_R.OcxState")));
            this.axAxisMediaControl_R.Size = new System.Drawing.Size(240, 240);
            this.axAxisMediaControl_R.TabIndex = 26;
            // 
            // pictureBox_cara_reclutamiento
            // 
            this.pictureBox_cara_reclutamiento.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cara_reclutamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_cara_reclutamiento.Location = new System.Drawing.Point(296, 187);
            this.pictureBox_cara_reclutamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_cara_reclutamiento.Name = "pictureBox_cara_reclutamiento";
            this.pictureBox_cara_reclutamiento.Size = new System.Drawing.Size(159, 159);
            this.pictureBox_cara_reclutamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_cara_reclutamiento.TabIndex = 14;
            this.pictureBox_cara_reclutamiento.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Facial";
            // 
            // button_borrar_caras
            // 
            this.button_borrar_caras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_caras.Location = new System.Drawing.Point(20, 639);
            this.button_borrar_caras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_caras.Name = "button_borrar_caras";
            this.button_borrar_caras.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_caras.TabIndex = 25;
            this.button_borrar_caras.Text = "Borrar todas";
            this.button_borrar_caras.UseVisualStyleBackColor = true;
            this.button_borrar_caras.Click += new System.EventHandler(this.button_borrar_caras_Click);
            // 
            // button_cara
            // 
            this.button_cara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cara.Location = new System.Drawing.Point(192, 513);
            this.button_cara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cara.Name = "button_cara";
            this.button_cara.Size = new System.Drawing.Size(100, 38);
            this.button_cara.TabIndex = 15;
            this.button_cara.Text = "Captura";
            this.button_cara.UseVisualStyleBackColor = true;
            this.button_cara.Click += new System.EventHandler(this.button_cara_Click);
            // 
            // button_borrar_cara
            // 
            this.button_borrar_cara.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_cara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_cara.Location = new System.Drawing.Point(20, 603);
            this.button_borrar_cara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_cara.Name = "button_borrar_cara";
            this.button_borrar_cara.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_cara.TabIndex = 24;
            this.button_borrar_cara.Text = "Borrar última";
            this.button_borrar_cara.UseVisualStyleBackColor = true;
            this.button_borrar_cara.Click += new System.EventHandler(this.button_borrar_cara_Click);
            // 
            // button_final_reclutamiento
            // 
            this.button_final_reclutamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_final_reclutamiento.Location = new System.Drawing.Point(336, 619);
            this.button_final_reclutamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_final_reclutamiento.Name = "button_final_reclutamiento";
            this.button_final_reclutamiento.Size = new System.Drawing.Size(113, 48);
            this.button_final_reclutamiento.TabIndex = 16;
            this.button_final_reclutamiento.Text = "Siguiente";
            this.button_final_reclutamiento.UseVisualStyleBackColor = true;
            this.button_final_reclutamiento.Click += new System.EventHandler(this.button_final_reclutamiento_Click);
            // 
            // label_caras_reclutamiento
            // 
            this.label_caras_reclutamiento.AutoSize = true;
            this.label_caras_reclutamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_caras_reclutamiento.Location = new System.Drawing.Point(208, 555);
            this.label_caras_reclutamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_caras_reclutamiento.Name = "label_caras_reclutamiento";
            this.label_caras_reclutamiento.Size = new System.Drawing.Size(29, 31);
            this.label_caras_reclutamiento.TabIndex = 18;
            this.label_caras_reclutamiento.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(232, 555);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 31);
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
            this.panel_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Size = new System.Drawing.Size(288, 681);
            this.panel_ID.TabIndex = 26;
            // 
            // button_ID
            // 
            this.button_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ID.Location = new System.Drawing.Point(85, 396);
            this.button_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ID.Name = "button_ID";
            this.button_ID.Size = new System.Drawing.Size(113, 39);
            this.button_ID.TabIndex = 7;
            this.button_ID.Text = "Siguiente";
            this.button_ID.UseVisualStyleBackColor = true;
            this.button_ID.Click += new System.EventHandler(this.button_ID_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(28, 206);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(223, 22);
            this.textBox_nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(28, 273);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(223, 22);
            this.textBox_ID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI sin letra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Identificación";
            // 
            // tab_visita1
            // 
            this.tab_visita1.Controls.Add(this.panel_cara_v1);
            this.tab_visita1.Controls.Add(this.panel_huella_v1);
            this.tab_visita1.Location = new System.Drawing.Point(4, 25);
            this.tab_visita1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_visita1.Name = "tab_visita1";
            this.tab_visita1.Size = new System.Drawing.Size(1164, 685);
            this.tab_visita1.TabIndex = 2;
            this.tab_visita1.Text = "Visita 1";
            this.tab_visita1.UseVisualStyleBackColor = true;
            // 
            // panel_cara_v1
            // 
            this.panel_cara_v1.Controls.Add(this.label15);
            this.panel_cara_v1.Controls.Add(this.axAxisMediaControl_V1);
            this.panel_cara_v1.Controls.Add(this.pictureBox_cara_v1);
            this.panel_cara_v1.Controls.Add(this.button_borrar_cara_v1);
            this.panel_cara_v1.Controls.Add(this.button_borrar_caras_v1);
            this.panel_cara_v1.Controls.Add(this.label_caras_V1);
            this.panel_cara_v1.Controls.Add(this.button_final_v1);
            this.panel_cara_v1.Controls.Add(this.label8);
            this.panel_cara_v1.Controls.Add(this.label13);
            this.panel_cara_v1.Controls.Add(this.button_cara_v1);
            this.panel_cara_v1.Enabled = false;
            this.panel_cara_v1.Location = new System.Drawing.Point(557, 0);
            this.panel_cara_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_cara_v1.Name = "panel_cara_v1";
            this.panel_cara_v1.Size = new System.Drawing.Size(604, 682);
            this.panel_cara_v1.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 21);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 17);
            this.label15.TabIndex = 46;
            this.label15.Text = "ESCENARIO 3";
            // 
            // axAxisMediaControl_V1
            // 
            this.axAxisMediaControl_V1.Enabled = true;
            this.axAxisMediaControl_V1.Location = new System.Drawing.Point(58, 74);
            this.axAxisMediaControl_V1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axAxisMediaControl_V1.Name = "axAxisMediaControl_V1";
            this.axAxisMediaControl_V1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxisMediaControl_V1.OcxState")));
            this.axAxisMediaControl_V1.Size = new System.Drawing.Size(240, 320);
            this.axAxisMediaControl_V1.TabIndex = 50;
            // 
            // pictureBox_cara_v1
            // 
            this.pictureBox_cara_v1.Location = new System.Drawing.Point(429, 217);
            this.pictureBox_cara_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_cara_v1.Name = "pictureBox_cara_v1";
            this.pictureBox_cara_v1.Size = new System.Drawing.Size(141, 167);
            this.pictureBox_cara_v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_cara_v1.TabIndex = 33;
            this.pictureBox_cara_v1.TabStop = false;
            // 
            // button_borrar_cara_v1
            // 
            this.button_borrar_cara_v1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_cara_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_cara_v1.Location = new System.Drawing.Point(13, 608);
            this.button_borrar_cara_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_cara_v1.Name = "button_borrar_cara_v1";
            this.button_borrar_cara_v1.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_cara_v1.TabIndex = 38;
            this.button_borrar_cara_v1.Text = "Borrar última";
            this.button_borrar_cara_v1.UseVisualStyleBackColor = true;
            this.button_borrar_cara_v1.Click += new System.EventHandler(this.button_borrar_cara_Click);
            // 
            // button_borrar_caras_v1
            // 
            this.button_borrar_caras_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_caras_v1.Location = new System.Drawing.Point(13, 644);
            this.button_borrar_caras_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_caras_v1.Name = "button_borrar_caras_v1";
            this.button_borrar_caras_v1.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_caras_v1.TabIndex = 39;
            this.button_borrar_caras_v1.Text = "Borrar todas";
            this.button_borrar_caras_v1.UseVisualStyleBackColor = true;
            this.button_borrar_caras_v1.Click += new System.EventHandler(this.button_borrar_caras_v1_Click);
            // 
            // label_caras_V1
            // 
            this.label_caras_V1.AutoSize = true;
            this.label_caras_V1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_caras_V1.Location = new System.Drawing.Point(272, 570);
            this.label_caras_V1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_caras_V1.Name = "label_caras_V1";
            this.label_caras_V1.Size = new System.Drawing.Size(29, 31);
            this.label_caras_V1.TabIndex = 36;
            this.label_caras_V1.Text = "0";
            // 
            // button_final_v1
            // 
            this.button_final_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_final_v1.Location = new System.Drawing.Point(475, 602);
            this.button_final_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_final_v1.Name = "button_final_v1";
            this.button_final_v1.Size = new System.Drawing.Size(113, 48);
            this.button_final_v1.TabIndex = 35;
            this.button_final_v1.Text = "Siguiente";
            this.button_final_v1.UseVisualStyleBackColor = true;
            this.button_final_v1.Click += new System.EventHandler(this.button_final_v1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 570);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 31);
            this.label8.TabIndex = 37;
            this.label8.Text = "/5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(229, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 31);
            this.label13.TabIndex = 32;
            this.label13.Text = "Facial";
            // 
            // button_cara_v1
            // 
            this.button_cara_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cara_v1.Location = new System.Drawing.Point(253, 528);
            this.button_cara_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cara_v1.Name = "button_cara_v1";
            this.button_cara_v1.Size = new System.Drawing.Size(100, 38);
            this.button_cara_v1.TabIndex = 34;
            this.button_cara_v1.Text = "Captura";
            this.button_cara_v1.UseVisualStyleBackColor = true;
            this.button_cara_v1.Click += new System.EventHandler(this.button_cara_v1_Click);
            // 
            // panel_huella_v1
            // 
            this.panel_huella_v1.Controls.Add(this.label12);
            this.panel_huella_v1.Controls.Add(this.button_huella_siguiente_v1);
            this.panel_huella_v1.Controls.Add(this.label11);
            this.panel_huella_v1.Controls.Add(this.pictureBox_huella_v1);
            this.panel_huella_v1.Controls.Add(this.button_huella_v1);
            this.panel_huella_v1.Controls.Add(this.label_huellas_V1);
            this.panel_huella_v1.Controls.Add(this.label7);
            this.panel_huella_v1.Controls.Add(this.button_borrar_huella_v1);
            this.panel_huella_v1.Controls.Add(this.button_borrar_huellas_v1);
            this.panel_huella_v1.Enabled = false;
            this.panel_huella_v1.Location = new System.Drawing.Point(-3, 4);
            this.panel_huella_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_huella_v1.Name = "panel_huella_v1";
            this.panel_huella_v1.Size = new System.Drawing.Size(565, 678);
            this.panel_huella_v1.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "ESCENARIO 1";
            // 
            // button_huella_siguiente_v1
            // 
            this.button_huella_siguiente_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella_siguiente_v1.Location = new System.Drawing.Point(399, 598);
            this.button_huella_siguiente_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_huella_siguiente_v1.Name = "button_huella_siguiente_v1";
            this.button_huella_siguiente_v1.Size = new System.Drawing.Size(111, 48);
            this.button_huella_siguiente_v1.TabIndex = 27;
            this.button_huella_siguiente_v1.Text = "Siguiente";
            this.button_huella_siguiente_v1.UseVisualStyleBackColor = true;
            this.button_huella_siguiente_v1.Click += new System.EventHandler(this.button_huella_siguiente_v1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(201, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 31);
            this.label11.TabIndex = 24;
            this.label11.Text = "Huella";
            // 
            // pictureBox_huella_v1
            // 
            this.pictureBox_huella_v1.Location = new System.Drawing.Point(140, 134);
            this.pictureBox_huella_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_huella_v1.Name = "pictureBox_huella_v1";
            this.pictureBox_huella_v1.Size = new System.Drawing.Size(247, 299);
            this.pictureBox_huella_v1.TabIndex = 25;
            this.pictureBox_huella_v1.TabStop = false;
            // 
            // button_huella_v1
            // 
            this.button_huella_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella_v1.Location = new System.Drawing.Point(208, 471);
            this.button_huella_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_huella_v1.Name = "button_huella_v1";
            this.button_huella_v1.Size = new System.Drawing.Size(100, 38);
            this.button_huella_v1.TabIndex = 26;
            this.button_huella_v1.Text = "Captura";
            this.button_huella_v1.UseVisualStyleBackColor = true;
            this.button_huella_v1.Click += new System.EventHandler(this.button_huella_v1_Click);
            // 
            // label_huellas_V1
            // 
            this.label_huellas_V1.AutoSize = true;
            this.label_huellas_V1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_huellas_V1.Location = new System.Drawing.Point(225, 513);
            this.label_huellas_V1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_huellas_V1.Name = "label_huellas_V1";
            this.label_huellas_V1.Size = new System.Drawing.Size(29, 31);
            this.label_huellas_V1.TabIndex = 28;
            this.label_huellas_V1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 513);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 31);
            this.label7.TabIndex = 29;
            this.label7.Text = "/5";
            // 
            // button_borrar_huella_v1
            // 
            this.button_borrar_huella_v1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_huella_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huella_v1.Location = new System.Drawing.Point(16, 604);
            this.button_borrar_huella_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_huella_v1.Name = "button_borrar_huella_v1";
            this.button_borrar_huella_v1.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_huella_v1.TabIndex = 30;
            this.button_borrar_huella_v1.Text = "Borrar última";
            this.button_borrar_huella_v1.UseVisualStyleBackColor = true;
            this.button_borrar_huella_v1.Click += new System.EventHandler(this.button_borrar_huella_Click);
            // 
            // button_borrar_huellas_v1
            // 
            this.button_borrar_huellas_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huellas_v1.Location = new System.Drawing.Point(16, 640);
            this.button_borrar_huellas_v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_huellas_v1.Name = "button_borrar_huellas_v1";
            this.button_borrar_huellas_v1.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_huellas_v1.TabIndex = 31;
            this.button_borrar_huellas_v1.Text = "Borrar todas";
            this.button_borrar_huellas_v1.UseVisualStyleBackColor = true;
            this.button_borrar_huellas_v1.Click += new System.EventHandler(this.button_borrar_huellas_v1_Click);
            // 
            // tab_visita2
            // 
            this.tab_visita2.Controls.Add(this.panel_huella_v2);
            this.tab_visita2.Controls.Add(this.panel_cara_v2);
            this.tab_visita2.Controls.Add(this.label16);
            this.tab_visita2.Location = new System.Drawing.Point(4, 25);
            this.tab_visita2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_visita2.Name = "tab_visita2";
            this.tab_visita2.Size = new System.Drawing.Size(1164, 685);
            this.tab_visita2.TabIndex = 3;
            this.tab_visita2.Text = "Visita 2";
            this.tab_visita2.UseVisualStyleBackColor = true;
            // 
            // panel_huella_v2
            // 
            this.panel_huella_v2.Controls.Add(this.button_borrar_huella_v2);
            this.panel_huella_v2.Controls.Add(this.label20);
            this.panel_huella_v2.Controls.Add(this.pictureBox_huella_v2);
            this.panel_huella_v2.Controls.Add(this.button_huella_v2);
            this.panel_huella_v2.Controls.Add(this.button_fin);
            this.panel_huella_v2.Controls.Add(this.label_huellas_V2);
            this.panel_huella_v2.Controls.Add(this.label14);
            this.panel_huella_v2.Controls.Add(this.button_borrar_huellas_v2);
            this.panel_huella_v2.Enabled = false;
            this.panel_huella_v2.Location = new System.Drawing.Point(564, 2);
            this.panel_huella_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_huella_v2.Name = "panel_huella_v2";
            this.panel_huella_v2.Size = new System.Drawing.Size(597, 684);
            this.panel_huella_v2.TabIndex = 64;
            // 
            // button_borrar_huella_v2
            // 
            this.button_borrar_huella_v2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_huella_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huella_v2.Location = new System.Drawing.Point(20, 606);
            this.button_borrar_huella_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_huella_v2.Name = "button_borrar_huella_v2";
            this.button_borrar_huella_v2.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_huella_v2.TabIndex = 64;
            this.button_borrar_huella_v2.Text = "Borrar última";
            this.button_borrar_huella_v2.UseVisualStyleBackColor = true;
            this.button_borrar_huella_v2.Click += new System.EventHandler(this.button_borrar_huella_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(243, 74);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 31);
            this.label20.TabIndex = 71;
            this.label20.Text = "Huella";
            // 
            // pictureBox_huella_v2
            // 
            this.pictureBox_huella_v2.Location = new System.Drawing.Point(181, 154);
            this.pictureBox_huella_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_huella_v2.Name = "pictureBox_huella_v2";
            this.pictureBox_huella_v2.Size = new System.Drawing.Size(247, 299);
            this.pictureBox_huella_v2.TabIndex = 46;
            this.pictureBox_huella_v2.TabStop = false;
            // 
            // button_huella_v2
            // 
            this.button_huella_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huella_v2.Location = new System.Drawing.Point(255, 510);
            this.button_huella_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_huella_v2.Name = "button_huella_v2";
            this.button_huella_v2.Size = new System.Drawing.Size(100, 38);
            this.button_huella_v2.TabIndex = 47;
            this.button_huella_v2.Text = "Captura";
            this.button_huella_v2.UseVisualStyleBackColor = true;
            this.button_huella_v2.Click += new System.EventHandler(this.button_huella_v2_Click);
            // 
            // button_fin
            // 
            this.button_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fin.Location = new System.Drawing.Point(452, 622);
            this.button_fin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_fin.Name = "button_fin";
            this.button_fin.Size = new System.Drawing.Size(111, 48);
            this.button_fin.TabIndex = 48;
            this.button_fin.Text = "Siguiente";
            this.button_fin.UseVisualStyleBackColor = true;
            this.button_fin.Click += new System.EventHandler(this.button_fin_Click);
            // 
            // label_huellas_V2
            // 
            this.label_huellas_V2.AutoSize = true;
            this.label_huellas_V2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_huellas_V2.Location = new System.Drawing.Point(273, 551);
            this.label_huellas_V2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_huellas_V2.Name = "label_huellas_V2";
            this.label_huellas_V2.Size = new System.Drawing.Size(29, 31);
            this.label_huellas_V2.TabIndex = 49;
            this.label_huellas_V2.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(299, 551);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 31);
            this.label14.TabIndex = 50;
            this.label14.Text = "/5";
            // 
            // button_borrar_huellas_v2
            // 
            this.button_borrar_huellas_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_huellas_v2.Location = new System.Drawing.Point(20, 641);
            this.button_borrar_huellas_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_huellas_v2.Name = "button_borrar_huellas_v2";
            this.button_borrar_huellas_v2.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_huellas_v2.TabIndex = 65;
            this.button_borrar_huellas_v2.Text = "Borrar todas";
            this.button_borrar_huellas_v2.UseVisualStyleBackColor = true;
            this.button_borrar_huellas_v2.Click += new System.EventHandler(this.button_borrar_huellas_v2_Click);
            // 
            // panel_cara_v2
            // 
            this.panel_cara_v2.Controls.Add(this.axAxisMediaControl_V2);
            this.panel_cara_v2.Controls.Add(this.pictureBox_cara_v2);
            this.panel_cara_v2.Controls.Add(this.button_borrar_cara_v2);
            this.panel_cara_v2.Controls.Add(this.button_borrar_caras_v2);
            this.panel_cara_v2.Controls.Add(this.label19);
            this.panel_cara_v2.Controls.Add(this.label17);
            this.panel_cara_v2.Controls.Add(this.button_cara_v2);
            this.panel_cara_v2.Controls.Add(this.label_caras_V2);
            this.panel_cara_v2.Controls.Add(this.button_cara_siguiente_v2);
            this.panel_cara_v2.Enabled = false;
            this.panel_cara_v2.Location = new System.Drawing.Point(0, 0);
            this.panel_cara_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_cara_v2.Name = "panel_cara_v2";
            this.panel_cara_v2.Size = new System.Drawing.Size(568, 682);
            this.panel_cara_v2.TabIndex = 72;
            // 
            // axAxisMediaControl_V2
            // 
            this.axAxisMediaControl_V2.Enabled = true;
            this.axAxisMediaControl_V2.Location = new System.Drawing.Point(24, 80);
            this.axAxisMediaControl_V2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axAxisMediaControl_V2.Name = "axAxisMediaControl_V2";
            this.axAxisMediaControl_V2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxisMediaControl_V2.OcxState")));
            this.axAxisMediaControl_V2.Size = new System.Drawing.Size(240, 320);
            this.axAxisMediaControl_V2.TabIndex = 64;
            // 
            // pictureBox_cara_v2
            // 
            this.pictureBox_cara_v2.Location = new System.Drawing.Point(391, 213);
            this.pictureBox_cara_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_cara_v2.Name = "pictureBox_cara_v2";
            this.pictureBox_cara_v2.Size = new System.Drawing.Size(149, 166);
            this.pictureBox_cara_v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_cara_v2.TabIndex = 59;
            this.pictureBox_cara_v2.TabStop = false;
            // 
            // button_borrar_cara_v2
            // 
            this.button_borrar_cara_v2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_borrar_cara_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_cara_v2.Location = new System.Drawing.Point(12, 608);
            this.button_borrar_cara_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_cara_v2.Name = "button_borrar_cara_v2";
            this.button_borrar_cara_v2.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_cara_v2.TabIndex = 51;
            this.button_borrar_cara_v2.Text = "Borrar última";
            this.button_borrar_cara_v2.UseVisualStyleBackColor = true;
            this.button_borrar_cara_v2.Click += new System.EventHandler(this.button_borrar_cara_Click);
            // 
            // button_borrar_caras_v2
            // 
            this.button_borrar_caras_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar_caras_v2.Location = new System.Drawing.Point(12, 644);
            this.button_borrar_caras_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_borrar_caras_v2.Name = "button_borrar_caras_v2";
            this.button_borrar_caras_v2.Size = new System.Drawing.Size(156, 28);
            this.button_borrar_caras_v2.TabIndex = 52;
            this.button_borrar_caras_v2.Text = "Borrar todas";
            this.button_borrar_caras_v2.UseVisualStyleBackColor = true;
            this.button_borrar_caras_v2.Click += new System.EventHandler(this.button_borrar_caras_v2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(196, 37);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 31);
            this.label19.TabIndex = 58;
            this.label19.Text = "Facial";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(251, 569);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 31);
            this.label17.TabIndex = 63;
            this.label17.Text = "/5";
            // 
            // button_cara_v2
            // 
            this.button_cara_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cara_v2.Location = new System.Drawing.Point(205, 527);
            this.button_cara_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cara_v2.Name = "button_cara_v2";
            this.button_cara_v2.Size = new System.Drawing.Size(100, 38);
            this.button_cara_v2.TabIndex = 60;
            this.button_cara_v2.Text = "Captura";
            this.button_cara_v2.UseVisualStyleBackColor = true;
            this.button_cara_v2.Click += new System.EventHandler(this.button_cara_v2_Click);
            // 
            // label_caras_V2
            // 
            this.label_caras_V2.AutoSize = true;
            this.label_caras_V2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_caras_V2.Location = new System.Drawing.Point(228, 569);
            this.label_caras_V2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_caras_V2.Name = "label_caras_V2";
            this.label_caras_V2.Size = new System.Drawing.Size(29, 31);
            this.label_caras_V2.TabIndex = 62;
            this.label_caras_V2.Text = "0";
            // 
            // button_cara_siguiente_v2
            // 
            this.button_cara_siguiente_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cara_siguiente_v2.Location = new System.Drawing.Point(412, 624);
            this.button_cara_siguiente_v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cara_siguiente_v2.Name = "button_cara_siguiente_v2";
            this.button_cara_siguiente_v2.Size = new System.Drawing.Size(113, 48);
            this.button_cara_siguiente_v2.TabIndex = 61;
            this.button_cara_siguiente_v2.Text = "Siguiente";
            this.button_cara_siguiente_v2.UseVisualStyleBackColor = true;
            this.button_cara_siguiente_v2.Click += new System.EventHandler(this.button_cara_siguiente_v2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(451, -60);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 31);
            this.label16.TabIndex = 45;
            this.label16.Text = "Huella";
            // 
            // timer_cara_reclutamiento
            // 
            this.timer_cara_reclutamiento.Interval = 50;
            this.timer_cara_reclutamiento.Tick += new System.EventHandler(this.timer_cara_reclutamiento_Tick);
            // 
            // timer_cara_v1
            // 
            this.timer_cara_v1.Interval = 50;
            this.timer_cara_v1.Tick += new System.EventHandler(this.timer_cara_v1_Tick);
            // 
            // timer_cara_v2
            // 
            this.timer_cara_v2.Interval = 50;
            this.timer_cara_v2.Tick += new System.EventHandler(this.timer_cara_v2_Tick);
            // 
            // timeOutCara_R
            // 
            this.timeOutCara_R.Interval = 10000;
            this.timeOutCara_R.Tick += new System.EventHandler(this.timeOutCara_R_Tick);
            // 
            // timeOutCara_V1
            // 
            this.timeOutCara_V1.Interval = 10000;
            this.timeOutCara_V1.Tick += new System.EventHandler(this.timeOutCara_R_Tick);
            // 
            // timeOutCara_V2
            // 
            this.timeOutCara_V2.Interval = 10000;
            this.timeOutCara_V2.Tick += new System.EventHandler(this.timeOutCara_R_Tick);
            // 
            // label_busca_tablet
            // 
            this.label_busca_tablet.AutoSize = true;
            this.label_busca_tablet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busca_tablet.Location = new System.Drawing.Point(271, 647);
            this.label_busca_tablet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_busca_tablet.Name = "label_busca_tablet";
            this.label_busca_tablet.Size = new System.Drawing.Size(142, 20);
            this.label_busca_tablet.TabIndex = 10;
            this.label_busca_tablet.Text = "Buscando tablet...";
            this.label_busca_tablet.Visible = false;
            // 
            // App_Puerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 715);
            this.Controls.Add(this.Controles);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cara_v1)).EndInit();
            this.panel_huella_v1.ResumeLayout(false);
            this.panel_huella_v1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_huella_v1)).EndInit();
            this.tab_visita2.ResumeLayout(false);
            this.tab_visita2.PerformLayout();
            this.panel_huella_v2.ResumeLayout(false);
            this.panel_huella_v2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_huella_v2)).EndInit();
            this.panel_cara_v2.ResumeLayout(false);
            this.panel_cara_v2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxisMediaControl_V2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cara_v2)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.TabControl Controles;
        private System.Windows.Forms.TabPage tab_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ID_inicio;
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
        private System.Windows.Forms.Label label_huellas_V1;
        private System.Windows.Forms.Button button_huella_siguiente_v1;
        private System.Windows.Forms.Button button_huella_v1;
        private System.Windows.Forms.PictureBox pictureBox_huella_v1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_borrar_caras_v1;
        private System.Windows.Forms.Button button_borrar_cara_v1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_caras_V1;
        private System.Windows.Forms.Button button_final_v1;
        private System.Windows.Forms.Button button_cara_v1;
        private System.Windows.Forms.PictureBox pictureBox_cara_v1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_borrar_huellas_v2;
        private System.Windows.Forms.Button button_borrar_huella_v2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_caras_V2;
        private System.Windows.Forms.Button button_cara_siguiente_v2;
        private System.Windows.Forms.Button button_cara_v2;
        private System.Windows.Forms.PictureBox pictureBox_cara_v2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_borrar_caras_v2;
        private System.Windows.Forms.Button button_borrar_cara_v2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_huellas_V2;
        private System.Windows.Forms.Button button_fin;
        private System.Windows.Forms.Button button_huella_v2;
        private System.Windows.Forms.PictureBox pictureBox_huella_v2;
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
        private Timer timer_cara_v1;
        private Timer timer_cara_v2;
        private Timer timeOutCara_R;
        private Timer timeOutCara_V1;
        private Timer timeOutCara_V2;
        private Label IP_label;
        private TextBox textBox_IP;
        private Button button_IP;
        private Label OK_tablet;
        private Button button_tablet;
        private Label label_busca_tablet;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Puerta
{
    public partial class App_Puerta : Form
    {
        public App_Puerta()
        {
            InitializeComponent();
        }

        /* EVENTOS DE BOTÓN */


        //PANEL DE INICIO

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            Menu.SelectedTab = tab_reclutamiento;
            panel_ID.Enabled = true;
        }

        private void button_existente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nombre_inicio.Text) || textBox_nombre_inicio.Text.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Por favor, introduce un DNI sin letra");
            }
            else
            {
                // AQUÍ HAY QUE COMPROBAR QUE ESTÉ EN LA BD Y QUÉ TIENE COMPLETADO (V1 / V2)
                textBox_nombre_inicio.Text = "";
                Menu.SelectedTab = tab_visita2;
                //HABILITAR LA CÁMARA 
                panel_cara_v2.Enabled = true;
            }
        }

        private void button_habilitar_Click(object sender, EventArgs e)
        {
            panel_ID.Enabled = true;
            panel_cara.Enabled = true;
            panel_huella.Enabled = true;
            panel_cara_v1.Enabled = true;
            panel_huella_v1.Enabled = true;
            panel_cara_v2.Enabled = true;
            panel_huella_v2.Enabled = true;
        }

        //RECLUTAMIENTO

        private void button_ID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nombre.Text) || string.IsNullOrWhiteSpace(textBox_ID.Text) || textBox_ID.Text.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Por favor, introduce nombre y DNI sin letra");
            }
            else
            {
                panel_huella.Enabled = true;
            }
        }

        private void button_huella_siguiente_Click(object sender, EventArgs e)
        {

            //COMPROBAR QUE TENEMOS TODAS LAS HUELLAS, SI NO, AVISAR!
            //HABILITAR LA CÁMARA            
            panel_cara.Enabled = true;
        }

        private void button_final_reclutamiento_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS CARAS, SI NO, AVISAR!
            //DESHABILITAR LA CÁMARA            
            panel_huella_v1.Enabled = true;
            Menu.SelectedTab = tab_visita1;
        }

        //VISITA 1

        private void button_huella_siguiente_v1_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS HUELLAS, SI NO, AVISAR!
            //HABILITAR LA CÁMARA            
            panel_cara_v1.Enabled = true;
        }

        private void button_final_v1_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS CARAS, SI NO, AVISAR!
            //DESHABILITAR LA CÁMARA 
            MessageBox.Show("Fin de la visita 1. Continue en el móvil");
            Menu.SelectedTab = tab_inicio;
        }

        //VISITA 2

        private void button_cara_siguiente_v2_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS CARAS, SI NO, AVISAR!
            //DESHABILITAR LA CÁMARA
            panel_huella_v2.Enabled = true;
        }

        private void button_fin_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS MUESTRAS, SI NO, AVISAR!
            MessageBox.Show("Fin de la visita 2. Continue en el móvil");
            Menu.SelectedTab = tab_inicio;
        }

        /********************/



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void huella_result_5_v2_Click(object sender, EventArgs e)
        {

        }

        private void huella_result_4_v2_Click(object sender, EventArgs e)
        {

        }

        private void huella_result_3_v2_Click(object sender, EventArgs e)
        {

        }

        private void huella_result_2_v2_Click(object sender, EventArgs e)
        {

        }

        private void huella_result_1_v2_Click(object sender, EventArgs e)
        {

        }

        
    }
}

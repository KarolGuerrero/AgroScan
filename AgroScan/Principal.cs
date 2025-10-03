using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgroScan
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CargarImagen(ofd.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void CargarImagen(string rutaArchivo)
        {
            // Leer archivo en bytes
            byte[] bytes = File.ReadAllBytes(rutaArchivo);
            int total = bytes.Length;
            int chunkSize = total / 100; // dividir en 100 partes (1% cada paso)

            using (MemoryStream ms = new MemoryStream())
            {
                for (int i = 0; i < total; i++)
                {
                    ms.WriteByte(bytes[i]);

                    // Actualizar progreso cada chunk
                    if (i % chunkSize == 0 && progressBar1.Value < 100)
                    {
                        progressBar1.Value++;
                        Application.DoEvents(); // refrescar UI mientras carga
                    }
                }

                // Convertir a imagen y mostrar
                ms.Position = 0;
                Image img = Image.FromStream(ms);
                ImageUpload.BackgroundImage = img;
            }

            progressBar1.Value = 100; // asegurar que termina en 100

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bordeRich_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}




       
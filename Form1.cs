using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;//..
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aprendendo
{
    public partial class Form1 : Form
    {
        Thread on;
        Thread ing;
        Thread cri;

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//comprar ingresso
        {
            this.Close();
            ing = new Thread(abrir);
            ing.SetApartmentState(ApartmentState.MTA);
            ing.Start();
        }
        private void abrir(object obj)
        {
            Application.Run(new ingresso());
        }






        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//assistir oline
        {
           this.Close();
            on = new Thread(abrirjanela);
            on.SetApartmentState(ApartmentState.MTA);
            on.Start();
        }
        private void abrirjanela(object obj)
        {
            Application.Run(new salaoline());
        }

        private void button2_Click(object sender, EventArgs e)//Criar conta
        {
            this.Close();
            cri = new Thread(criar);
            cri.SetApartmentState(ApartmentState.MTA);
            cri.Start();

        }
        private void criar(object obj)
        {
            Application.Run(new criar());
        }



    }
}

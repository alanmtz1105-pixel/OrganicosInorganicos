using System;
using System.Drawing;
using System.Windows.Forms;


namespace OrganicosInorganicos
{

    public partial class Form1 : Form
    {
        PictureBox primeraCarta = null;
        PictureBox segundaCarta = null;

        int organicos = 0;
        int inorganicos = 0;
        public Form1()
        {
            InitializeComponent();


            picFruta1.Tag = "fruta";
            picFruta2.Tag = "fruta";


            picVerdura1.Tag = "verdura";
            picVerdura2.Tag = "verdura";


            picBotella1.Tag = "botella";
            picBotella2.Tag = "botella";


            picVidrio1.Tag = "vidrio";
            picVidrio2.Tag = "vidrio";

            picllanta1.Tag = "llanta";
            picllanta2.Tag = "llanta";

            piccarton1.Tag = "carton";
            piccarton2.Tag = "carton";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;

            progressOrganicos.Maximum = 2;
            progressInorganicos.Maximum = 4;
        }

        private void Carta_Click(object sender, EventArgs e)
        {
            PictureBox cartaSeleccionada = (PictureBox)sender;


            MostrarImagen(cartaSeleccionada);


            if (cartaSeleccionada == primeraCarta)
            {
                return;
            }


            if (primeraCarta == null)
            {
                primeraCarta = cartaSeleccionada;
                return;
            }


            segundaCarta = cartaSeleccionada;


            if (primeraCarta.Tag.ToString() == segundaCarta.Tag.ToString())
            {
                lblResultadoJuego.Text = "¡Encontraste un par!";
                lblResultadoJuego.ForeColor = Color.Green;

                switch (primeraCarta.Tag.ToString())
                {


                    case "fruta":
                        lblInformacion.Text = "La fruta es un residuo ORGÁNICO";
                        this.BackColor = Color.LightGreen;

                        organicos++;
                        progressOrganicos.Value = organicos;



                        break;

                    case "verdura":
                        lblInformacion.Text = "La verdura es un residuo ORGÁNICO";
                        this.BackColor = Color.LightGreen;

                        organicos++;
                        progressOrganicos.Value = organicos;
                        break;

                    case "botella":
                        lblInformacion.Text = "La botella es INORGÁNICA";
                        this.BackColor = Color.LightBlue;
                        inorganicos++;
                        progressInorganicos.Value = inorganicos;
                        break;

                    case "llanta":
                        lblInformacion.Text = "La llanta es INORGÁNICA";
                        this.BackColor = Color.LightBlue;
                        inorganicos++;
                        progressInorganicos.Value = inorganicos;
                        break;

                    case "carton":
                        lblInformacion.Text = "El carton es INORGÁNICA";
                        this.BackColor = Color.LightBlue;
                        inorganicos++;
                        progressInorganicos.Value = inorganicos;
                        break;

                    case "vidrio":
                        lblInformacion.Text = "El vidrio es INORGÁNICO";
                        this.BackColor = Color.LightBlue;
                        inorganicos++;
                        progressInorganicos.Value = inorganicos;
                        break;
                }


                primeraCarta.Enabled = false;
                segundaCarta.Enabled = false;


                if (!picFruta1.Enabled &&
                    !picFruta2.Enabled &&
                    !picVerdura1.Enabled &&
                    !picVerdura2.Enabled &&
                    !picBotella1.Enabled &&
                    !picBotella2.Enabled &&
                    !picllanta1.Enabled &&
                    !picllanta2.Enabled &&
                    !piccarton1.Enabled &&
                    !piccarton2.Enabled &&
                    !picVidrio1.Enabled &&
                    !picVidrio2.Enabled)
                {
                    MessageBox.Show("¡Ganaste el memorama!");
                }
            }
            else
            {
                lblResultadoJuego.Text = "No es el par correcto";
                lblResultadoJuego.ForeColor = Color.Red;

                lblInformacion.Text = "Intenta nuevamente";


                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);

                primeraCarta.Image = Properties.Resources.tapa;
                segundaCarta.Image = Properties.Resources.tapa;
            }


            primeraCarta = null;
            segundaCarta = null;
        }
        private void MostrarImagen(PictureBox carta)
        {
            switch (carta.Tag.ToString())
            {


                case "fruta":
                    carta.Image = Properties.Resources.fruta;
                    break;

                case "verdura":
                    carta.Image = Properties.Resources.verdura;
                    break;

                case "botella":
                    carta.Image = Properties.Resources.botella;
                    break;

                case "vidrio":
                    carta.Image = Properties.Resources.vidrio;
                    break;

                case "llanta":
                    carta.Image = Properties.Resources.llanta;
                    break;

                case "carton":
                    carta.Image = Properties.Resources.carton;
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblInformacion_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoJuego_Click(object sender, EventArgs e)
        {

        }

        private void progressOrganicos_Click(object sender, EventArgs e)
        {

        }

        private void ORGÁNICOS_Click(object sender, EventArgs e)
        {

        }

        private void progressInorganicos_Click(object sender, EventArgs e)
        {

        }

        private void INORGÁNICOS_Click(object sender, EventArgs e)
        {

        }
    }
}
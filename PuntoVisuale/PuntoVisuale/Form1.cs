using PuntoNelloSpazio;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Xml.Serialization;

namespace PuntoVisuale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            // quadrato
            int x = 0, y = 0, @base = 0;
            Punto punto;

            if (DatiValidi(textBox1.Text, ref x) || DatiValidi(textBox2.Text, ref y))
            {
                punto = new Punto(x, y);
            }
            else
            {
                return;
            }

            //controllo dati per la creazione del quadrato

            if (!DatiValidi(textBox3.Text, ref @base))
            {
                return;
            }

            Quadrato quadrato = new Quadrato(@base, @base, punto);

            //aggiunto alla lista box
            listBox1.Items.Add(quadrato);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //rettangolo

            //creazione punto
            Punto punto;
            int x = 0, y = 0;
            int @base = 0, altezza = 0;
            if (DatiValidi(textBox1.Text, ref x) || DatiValidi(textBox2.Text, ref y))
            {
                punto = new Punto(x, y);
            }
            else
            {
                return;
            }

            //creazione rettangolo
            if (!DatiValidi(textBox3.Text, ref @base) || !DatiValidi(textBox4.Text, ref altezza))
            {
                return;
            }
            Rettangolo rettangolo = new Rettangolo(@base, altezza, punto);

            //aggiunto alla lista box
            listBox1.Items.Add(rettangolo);
        }

        private bool DatiValidi(string a, ref int valore1)
        {

            if (!int.TryParse(a, out valore1) || valore1 <= 0)
            {
                MessageBox.Show("Dati errati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //parallelepipido
            //creazione punto
            Punto punto;
            int x = 0, y = 0;
            int @base = 0, altezza = 0, profondita = 0;
            if (DatiValidi(textBox1.Text, ref x) || DatiValidi(textBox2.Text, ref y))
            {
                punto = new Punto(x, y);
            }
            else
            {
                return;
            }

            //creazione parallelepipido
            if (!DatiValidi(textBox3.Text, ref @base) || !DatiValidi(textBox4.Text, ref altezza) || !DatiValidi(textBox5.Text, ref profondita))
            {
                return;
            }
            Parallelepipido para = new Parallelepipido(@base, altezza, punto, profondita);

            //aggiunto alla lista box
            listBox1.Items.Add(para);
        }

        private void TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace Bar_Buddy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {

            float taxa = 0;
            int cover = 0;

            if (checkBoxTaxa.Checked == true)
            {
                taxa = 1.1f;

            }
            if (checkBoxTaxa.Checked == false)
            {
                taxa = 1;

            }
            if (checkBoxCover.Checked == true)
            {
                cover = 15;
            }

            validarCampo();
            float amigos = float.Parse(textBoxAmigos.Text);
            int valor = int.Parse(textBoxValor.Text);

            float resultado = ((valor * taxa) + cover) / amigos;



            labelResultado.Text = String.Format("Valor: {0}", resultado);

        }

        private bool validarCampo()
        {
            if (textBoxValor.Text.Equals(""))
            {
                MessageBox.Show("O Valor é obrigatório", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (textBoxAmigos.Text.Equals(""))
            {
                MessageBox.Show("A quantidade de Amigos é obrigatório", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}

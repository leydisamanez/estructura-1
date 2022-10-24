namespace estructura_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista lista = new Lista();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void busquedabtn_Click(object sender, EventArgs e)
        {

            try
            {
                string c = dato1txt.Text;
                lista.buscar(c, dgvmascota);
                dato1txt.Clear();
                MessageBox.Show("La mascota fue encontrada",
                     "Contactos");
                if (dato1txt.Text == " ")
                {
                    MessageBox.Show("El campo Nombres es obligatorio",
                      "Contactos");

                    nombreanimaltxt.Focus();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("El nombre de la mascota no fue encontrada",
               "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrarbtn_Click(object sender, EventArgs e)
        {
            try
            {



                lista.insertar( ""+  nombretxt.Text, direcciontxt.Text, int.Parse(telefonotxt.Text), nombreanimaltxt.Text, razacbo.Text , int.Parse(edadtxt.Text) );

                Mostrar_Click(sender, e);
                mostrarmascota_Click(sender, e);



                nombretxt.Clear();
                direcciontxt.Clear();
                telefonotxt.Clear();
                nombreanimaltxt.Clear();

                edadtxt.Clear();


            }



            catch (Exception)
            {
                MessageBox.Show("ingrese sus datos",
               "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            lista.desplegard(dgvdueño);

        }

        private void mostrarmascota_Click(object sender, EventArgs e)
        {
            lista.desplegarm(dgvmascota);

        }

        private void dgvmascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
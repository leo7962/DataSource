using System.Windows.Forms;

namespace DataSource
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            Validate();
            customersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(northwindDataSet);
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            customersTableAdapter.Fill(northwindDataSet.Customers);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void toolStripTextBox1_Click(object sender, System.EventArgs e)
        {
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                var index = customersBindingSource.Find("CustomerId", toolStripTextBox1.Text);

                if (index > -1)
                {
                    customersBindingSource.Position = index;
                    return;
                }

                MessageBox.Show("Elemento no encontrado");
            }
        }
    }
}
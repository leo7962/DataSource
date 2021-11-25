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
    }
}
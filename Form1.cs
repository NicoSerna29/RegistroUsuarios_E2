using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RegistroUsuarios_E2
{
    public partial class Form1 : Form
    {
        DataTable dataTable1;

        public Form1()
        {
            InitializeComponent();
            crearTabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTable1.Rows.Add(new object[] { textBox1.Text, textBox2.Text });
            textBox1.Text = " ";
            textBox2.Text = " ";
            MessageBox.Show("REGISTRADO", "REGISTRO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dataTable1.Rows)
            {
                foreach (DataColumn col in dataTable1.Columns)
                {
                    sb.Append(row[col].ToString() + "\t");
                }
                sb.AppendLine();
            }
            richTextBox1.Text = sb.ToString();
        }
        private void crearTabla()
        {
            dataTable1 = new DataTable();
            dataTable1.Columns.Add("Cedula", typeof(string));
            dataTable1.Columns.Add("Nombre", typeof(string));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
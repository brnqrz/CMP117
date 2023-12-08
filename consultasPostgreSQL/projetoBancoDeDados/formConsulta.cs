using Npgsql;
using System.Data;

namespace projetoBancoDeDados
{
    public partial class formConsulta : Form
    {
        private readonly string connectionString = "Server=localhost;Port=5432;Database=CMP1117;User Id=postgres;Password=postgres;";
        public formConsulta()
        {
            InitializeComponent();
        }

        public void realizaConsulta(string pathQuery)
        {
            using NpgsqlConnection postgreSQLConnection = new();
            postgreSQLConnection.ConnectionString = connectionString;
            postgreSQLConnection.Open();

            NpgsqlCommand postgreSQLCommand = new();
            postgreSQLCommand.Connection = postgreSQLConnection;
            var fileContent = File.ReadAllText(pathQuery);
            textBox.Text = fileContent;
        }

        public DataTable executaConsulta()
        {
            using NpgsqlConnection postgreSQLConnection = new();
            DataTable dt = new DataTable();
            postgreSQLConnection.ConnectionString = connectionString;
            postgreSQLConnection.Open();

            NpgsqlCommand postgreSQLCommand = new();
            postgreSQLCommand.Connection = postgreSQLConnection;

            postgreSQLCommand.CommandText = textBox.Text;

            NpgsqlDataReader dr = postgreSQLCommand.ExecuteReader();

            dt.Load(dr);
            return dt;
        }

        public void btnQ1_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\1.sql");
        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\2.sql");
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\3.sql");
        }

        private void btnQ4_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\4.sql");
        }

        private void btnQ5_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\5.sql");
        }

        private void btnQ6_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\6.sql");
        }

        private void btnQ7_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\7.sql");
        }

        private void btnQ8_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\8.sql");
        }

        private void btnQ9_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\9.sql");
        }

        private void btnQ10_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\10.sql");
        }

        private void btnQ11_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\11.sql");
        }

        private void btnQ12_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\12.sql");
        }

        private void btnQ13_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\13.sql");
        }

        private void btnQ14_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\14.sql");
        }

        private void btnQ15_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\15.sql");
        }

        private void btnQ16_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\16.sql");
        }

        private void btnQ17_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\17.sql");
        }

        private void btnQ18_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\18.sql");
        }

        private void btnQ19_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\19.sql");
        }

        private void btnQ20_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            retornoConsulta.DataSource = null;
            realizaConsulta("C:\\Users\\breno\\OneDrive\\Documentos\\CMP117\\consultasPostgreSQL\\queries\\20.sql");
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            retornoConsulta.DataSource = null;
            DataTable dtConsulta = new();
            retornoConsulta.DataSource = executaConsulta();
        }
    }
}
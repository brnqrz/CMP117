using Npgsql;
using System.Configuration;
using System.Data;

namespace projetoBancoDeDados
{
    public partial class formConsulta : Form
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["consultaDB"].ConnectionString;
        public formConsulta()
        {
            InitializeComponent();
        }

        public DataTable realizaConsulta(string pathQuery)
        {
            using NpgsqlConnection postgreSQLConnection = new();
            DataTable dt = new DataTable();

            postgreSQLConnection.ConnectionString = connectionString;
            postgreSQLConnection.Open();

            NpgsqlCommand postgreSQLCommand = new();
            postgreSQLCommand.Connection = postgreSQLConnection;

            var fileContent = File.ReadAllText("pathQuery");
            postgreSQLCommand.CommandText = fileContent;

            NpgsqlDataReader dr = postgreSQLCommand.ExecuteReader();

            dt.Load(dr);
            return dt;
        }

        private void btnQ1_Click(object sender, EventArgs e)
        {
            retornoConsulta.DataSource = null;
            DataTable dtConsulta = new();
            dtConsulta = realizaConsulta("1.sql");
            retornoConsulta.DataSource = dtConsulta;
        }
    }
}
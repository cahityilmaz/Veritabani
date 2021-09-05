using Microsoft.SqlServer.Management.Smo;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Veritabani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosing += (o, e) => { Application.ExitThread(); };
        }

        private void ComboDoldur()
        {
            Server server = new Server("localhost");
            cmbVeritabaniSec.Items.Clear();
            foreach (Database db in server.Databases)
            {
                if (db.Name != "msdb" && db.Name != "tempdb" && db.Name != "master" && db.Name != "model")
                {
                    cmbVeritabaniSec.Items.Add(db.Name);
                }
            }
        }

        private void CreateTables(string dbName)
        {
            string conStr = $"Data Source={Environment.MachineName}; Initial Catalog={dbName}; Integrated Security=True;";
            string modelPath = $"{Environment.CurrentDirectory}\\create.sql";
            SqlConnection connection;
            SqlCommand command;

            if (File.Exists(modelPath))
            {
                string sql = File.ReadAllText(modelPath);

                string[] text = sql.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                using (connection = new SqlConnection(conStr))
                {
                    using (command = new SqlCommand())
                    {
                        command.Connection = connection;
                        connection.Open();
                        foreach (string cmd in text)
                        {
                            command.CommandText = cmd;
                            command.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Tablolar Başarıyla Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Script Dosyası Bulunumadı !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateTables(string dbName)
        {
            string conStr = $"Data Source={Environment.MachineName}; Initial Catalog={dbName}; Integrated Security=True;";
            string modelPath = $"{Environment.CurrentDirectory}\\update.sql";
            SqlConnection connection;
            SqlCommand command;

            if (File.Exists(modelPath))
            {
                string sql = File.ReadAllText(modelPath);

                string[] text = sql.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                using (connection = new SqlConnection(conStr))
                {
                    using (command = new SqlCommand())
                    {
                        command.Connection = connection;
                        connection.Open();
                        foreach (string cmd in text)
                        {
                            command.CommandText = cmd;
                            command.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Script Dosyası Bulunumadı !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        private void btnVeritabaniOlustur_Click(object sender, EventArgs e)
        {
            string vt = txtVeritabaniAdi.Text.Trim();
            Server server = new Server("(local)");
            Database db = new Database(server, vt);
            db.Create();
            MessageBox.Show("Veritabanı Oluşturuldu");
            ComboDoldur();
        }

        private void btnTabloOlustur_Click(object sender, EventArgs e)
        {
            CreateTables(cmbVeritabaniSec.SelectedItem.ToString());
        }

        private void btnTabloGuncelle_Click(object sender, EventArgs e)
        {
            UpdateTables(cmbVeritabaniSec.SelectedItem.ToString());
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Select(0, textBox.Text.Length);
        }
    }
}
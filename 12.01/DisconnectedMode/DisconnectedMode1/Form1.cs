using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedMode1
{
    public partial class DataBase : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;
        public DataBase()
        {
            MessageBox.Show("Добро пожаловать", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitializeComponent();
            try
            {
                var builder = new ConfigurationBuilder();
                builder.AddUserSecrets<DataBase>();

                var config = builder.Build();

                var connectionString = config["DefaultConnection"];
                conn = new SqlConnection(connectionString);

                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            using SqlCommand command = new("Select [name] from sys.tables", conn);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
        }

        private void getAllDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Таблица пустая", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                adapter = new SqlDataAdapter($"select* from {comboBox1.SelectedItem.ToString()}", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                MessageBox.Show("Загрузка из база данных успешно прошло", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception zero)
            {
                MessageBox.Show("Не удалось загрузить базу данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlCommandBuilder builder = new(adapter);
                DataTable table = (DataTable)dataGridView1.DataSource;

                DataRow dataRow = table.NewRow();
                table.Rows.Add(dataRow);
                adapter.Update(table);
                MessageBox.Show("Успешно добавлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception zero)
            {
                MessageBox.Show($"Не удалось добавить элемент {zero.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlCommandBuilder builder = new(adapter);
                DataTable table = (DataTable)dataGridView1.DataSource;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        table.Rows[row.Index].Delete();
                    }
                    adapter.Update(table);
                    MessageBox.Show("Успешно удалено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите элементы для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception zero)
            {
                MessageBox.Show($"Не удалось удалить элемент {zero.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlCommandBuilder builder = new(adapter);
                DataTable table = (DataTable)dataGridView1.DataSource;
                adapter.Update(table);
                MessageBox.Show("Изменение успешно сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception zero)
            {
                MessageBox.Show($"Не удалось сохранить {zero.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

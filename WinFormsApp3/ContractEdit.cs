using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class ContractEdit : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        public ContractEdit()
        {
            InitializeComponent();
        }

        private void ContractEdit_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            CreateColumnsProduct();
            TakeContract(comboBoxUpper);
            RefreshDataGridProduct(dataGridView1);


        }

        private void CreateColumnsProduct()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("product", "Продукция");
            dataGridView1.Columns.Add("amount", "Количество");
            dataGridView1.Columns.Add("cost", "Стоимость");
            dataGridView1.Columns.Add("dicount", "Скидка");



        }

        private void ReadSingleRowProduct(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4));
        }

        private void RefreshDataGridProduct(DataGridView dgv)
        {
            var idContr = comboBoxUpper.SelectedValue;

            dgv.Rows.Clear();

            string queryString = $"select body.id, product.name, body.amount," +
                $"((product.cost*body.amount)-((product.cost*body.amount)/100*body.discount)), " +
                $"body.discount from body inner join upper on body.upper_id = upper.id " +
                $"inner join product on product.id = body.product_id where upper.id = '{idContr}';";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowProduct(dgv, reader);
            }
            reader.Close();
        }

        private void TakeContract(ComboBox cb)
        {
            string query = "SELECT id, concat(N'Договор № ',serial, N' от ', data_conf) as numb FROM upper"; 
            SqlCommand command = new SqlCommand(query, dataBase.getConnection()); 
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command); 
            adapter.Fill(table);
            comboBoxUpper.DataSource = table; 
            comboBoxUpper.DisplayMember = "numb"; 
            comboBoxUpper.ValueMember = "id"; 
        }



        private void comboBoxUpper_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshDataGridProduct(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TakeProduct(comboBoxProduct);
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxAmount.Text = row.Cells[2].Value.ToString();
                comboBoxProduct.Text = row.Cells[1].Value.ToString();
                comboBoxDiscount.Text = row.Cells[4].Value.ToString();
            }

        }

        private void TakeProduct(ComboBox cb)
        {
            string query = "SELECT id, name FROM product";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection()); 
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table); 
            comboBoxProduct.DataSource = table; 
            comboBoxProduct.DisplayMember = "name"; 
            comboBoxProduct.ValueMember = "id"; 
        }

        private void ChangeContract()
        {
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            var id = row.Cells[0].Value.ToString();
            dataBase.openConnection();
            var product_id = comboBoxProduct.SelectedValue;
            var discount = comboBoxDiscount.Text;
            int amount;

            if (dataGridView1.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBoxAmount.Text, out amount))
                {
                    var changeQuery = $"update body set product_id = '{product_id}', discount = '{discount}', amount = '{amount}'where id = '{id}';";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());

                    command.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("Количество должно быть числового значения");
                }
            }
            dataBase.closeConnection();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ChangeContract();
            RefreshDataGridProduct(dataGridView1);
        }

        private void DeleteRow()
        {
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            var id = row.Cells[0].Value.ToString();
            dataBase.openConnection();

            if (dataGridView1.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
            {
                var deleteQuery = $"delete from body where id = {id};";

                var command = new SqlCommand(deleteQuery, dataBase.getConnection());

                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Выберите позицию", "Ошибка", MessageBoxButtons.OK);
            }
            dataBase.closeConnection();
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            DeleteRow();
            RefreshDataGridProduct(dataGridView1);
        }


        private void DeleteUpper()
        {
            var id_up = comboBoxUpper.SelectedValue;

            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            dataBase.openConnection();

            if (dataGridView1.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
            {

                var deleteQuery = $"delete from upper where id = {id_up};";

                var command = new SqlCommand(deleteQuery, dataBase.getConnection());

                command.ExecuteNonQuery();

                dataBase.closeConnection();
            }
        }

        private void buttonDeleteCont_Click(object sender, EventArgs e)
        {

            DeleteUpper();
            TakeContract(comboBoxUpper);
            RefreshDataGridProduct(dataGridView1);
        }
    }
}

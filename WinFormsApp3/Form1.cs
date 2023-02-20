using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        enum RowState //Состояния на экране товаров
        {
            Изменено,
            Удалено,
            Готово
        }


        DataBase dataBase = new DataBase();
        int selectedRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColumnsProduct() //создание колонок
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Наименование");
            dataGridView1.Columns.Add("cost", "Цена");
            dataGridView1.Columns.Add("amount", "Наличие");
            dataGridView1.Columns.Add("amount_reserve", "Зарезервировано");
            dataGridView1.Columns.Add("status", String.Empty);


        }

        private void ReadSingleRowProduct(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), RowState.Готово);
        }

        private void RefreshDataGridProduct(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = $"select product.id, product.name, product.cost,warehouse.amount - warehouse.amount_reserve, warehouse.amount_reserve from product left join warehouse on product.id = warehouse.product_id ";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowProduct(dgv, reader);
            }
            reader.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewContr.AllowUserToAddRows = false;
            CreateColumnsProduct();
            RefreshDataGridProduct(dataGridView1);
            TakeContract(comboBoxContract);
            CreateColumnsContr();
            RefreshDataGridContr(dataGridViewContr);
            TakeTotal();
            TakeBuyer();
            TotalSend();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //занесение инфы из колонок в боксы
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                productBoxName.Text = row.Cells[1].Value.ToString();
                productBoxCost.Text = row.Cells[2].Value.ToString();
                productBoxAmountRes.Text = row.Cells[4].Value.ToString();
                productBoxAmount.Text = row.Cells[3].Value.ToString();
            }
        }

        private void UpdateProduct() //изменение продуктов в одном методе
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Готово)
                    continue;
                if (rowState == RowState.Удалено)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from product where id = {id};"; //+ $"delete from warehouse where product_id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Изменено)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var cost = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var amount = dataGridView1.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"update product set name = N'{name}', cost = '{cost}' where id = '{id}' ; update warehouse set amount = '{amount}' where product_id = '{id}';";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());

                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }




        private void DeleteRowProduct()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Cells[5].Value = RowState.Удалено;

        }

        private void changeProduct()
        {
            var selectedRow = dataGridView1.CurrentCell.RowIndex;

            var name = productBoxName.Text;
            int cost;
            int amount;

            if (dataGridView1.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(productBoxAmount.Text, out amount) && int.TryParse(productBoxCost.Text, out cost))
                {
                    dataGridView1.Rows[selectedRow].Cells[1].Value = name;
                    dataGridView1.Rows[selectedRow].Cells[2].Value = cost;
                    dataGridView1.Rows[selectedRow].Cells[3].Value = amount;
                    dataGridView1.Rows[selectedRow].Cells[5].Value = RowState.Изменено;
                }
                else
                {
                    MessageBox.Show("Цена и количество должны быть числового значения");
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeProduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Товар будет удален", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DeleteRowProduct();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateProduct();
            RefreshDataGridProduct(dataGridView1);
        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm();
            addform.ShowDialog();
        }

        private void buttonContractAdd_Click(object sender, EventArgs e)
        {
            ContractAdd contractAdd = new ContractAdd();
            contractAdd.ShowDialog();
        }

        //
        private void TakeContract(ComboBox cb) //выдача в комбобокс инфы о договорах
        {
            string query = "SELECT id, concat(N'Договор № ',serial, N' от ', data_conf) as numb FROM upper";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            comboBoxContract.DataSource = table;
            comboBoxContract.DisplayMember = "numb";
            comboBoxContract.ValueMember = "id";
        }

        private void CreateColumnsContr()
        {
            dataGridViewContr.Columns.Add("product", "Продукция");
            dataGridViewContr.Columns.Add("amount", "Количество");
            dataGridViewContr.Columns.Add("cost", "Стоимость");

        }

        private void ReadSingleRowContr(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetInt32(2));

        }

        private void RefreshDataGridContr(DataGridView dgv)
        {

            var idContr = comboBoxContract.SelectedValue;

            dgv.Rows.Clear();

            string queryString = $"select product.name, body.amount, " +
                $"((product.cost*body.amount)-((product.cost*body.amount)/100*body.discount)) " +
                $"from body " +
                $"inner join upper on body.upper_id = upper.id " +
                $"inner join product on product.id = body.product_id where upper.id = '{idContr}';";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowContr(dgv, reader);
            }
            reader.Close();

        }

        private void TakeTotal()
        {
            var idContr = comboBoxContract.SelectedValue;
            string commText1 = $"select  SUM((product.cost*body.amount)-((product.cost*body.amount)/100*body.discount)) as SUM " +
                $"from body  inner join upper on body.upper_id = upper.id inner join product on product.id = body.product_id" +
                $" where upper.id = '{idContr}';";

            SqlCommand command = new SqlCommand(commText1, dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            int total = reader.GetInt32("SUM");
            textBoxTotal.Text = total.ToString();

            reader.Close();
        }

        private void TakeBuyer()
        {
            var idContr = comboBoxContract.SelectedValue;
            string commText1 = $"select buyers.name from buyers inner join upper on buyers.Id = upper.buyers_id where upper.id = '{idContr}';";
            SqlCommand command = new SqlCommand(commText1, dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            string total = reader.GetString("name");
            textBoxBuyer.Text = total.ToString();

            reader.Close();
        }


        private void TotalSend() //перерасчет документа
        {
            var id = comboBoxContract.SelectedValue;
            var total = textBoxTotal.Text;
            Convert.ToInt32(total.ToString());
            var changeQuery = $"update upper set price='{total}' where id = '{id}';";

            var command = new SqlCommand(changeQuery, dataBase.getConnection());

            command.ExecuteNonQuery();
        }

        private void buttonContEdit_Click(object sender, EventArgs e)
        {
            ContractEdit contractEdit = new ContractEdit();
            contractEdit.Show();
        }

        private void comboBoxContract_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshDataGridContr(dataGridViewContr);
            TakeTotal();
            TakeBuyer();
            TotalSend();
        }
    }

}

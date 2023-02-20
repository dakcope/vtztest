using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class ContractAdd : Form
    {
        DataBase dataBase = new DataBase();

        public ContractAdd()
        {
            InitializeComponent();
            
        }


        private void TakeBuyer(ComboBox cb)
        {
            string query = "SELECT id, name FROM buyers"; 
            SqlCommand command = new SqlCommand(query, dataBase.getConnection()); 
            DataTable table = new DataTable(); 
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table); 
            comboBoxCont.DataSource = table;
            comboBoxCont.DisplayMember = "name"; 
            comboBoxCont.ValueMember = "id"; 
        }

        private void TakeProduct(ComboBox cb)
        {
            string query = "SELECT id, concat(name, N' за ' , cost ,N' рублей') as named FROM product";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection()); 
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command); 
            adapter.Fill(table);
            comboBox2.DataSource = table;
            comboBox2.DisplayMember = "named"; 
            comboBox2.ValueMember = "id"; 
        }

        private void ContractAdd_Load(object sender, EventArgs e)
        {
            TakeProduct(comboBox2);
            TakeBuyer(comboBoxCont);
        }

        private void buttonUpConf_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            string format = "yyyy-MM-dd";
            var data = (dateTime.Value.ToString(format));
            var buyer = comboBoxCont.SelectedValue;
            int serial;


            if (int.TryParse(textBoxSerial.Text, out serial))
            {
                
                var addQuer = $"insert into upper (serial, data_conf, buyers_id) values ('{serial}' ,'{data}' ,'{buyer}')";

                var command = new SqlCommand(addQuer, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Выберите товар, его количество и скидку", "Договор почти заключен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxCont.Enabled = false;
                textBoxSerial.Enabled = false;
                dateTime.Enabled = false;
                buttonUpConf.Visible = false;
                buttonAdd.Enabled = true;

            }
            else
            {
                MessageBox.Show("Номер документа должен содержать цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var buyerSerial = textBoxSerial.Text;
            var searchQuery = $"select id from upper where serial = '{buyerSerial}'";

            var commandSearch = new SqlCommand(searchQuery, dataBase.getConnection());

            SqlDataReader reader = commandSearch.ExecuteReader();

            reader.Read();
            var id = reader.GetInt32(0);
            reader.Close();

            var discount = comboBoxDisc.SelectedItem;
            var product = comboBox2.SelectedValue;
            int amount;

                if (int.TryParse(textBoxCount.Text, out amount))
                {

                    var addQuer = $"insert into body (upper_id, product_id, amount, discount) values ('{id}' ,'{product}' ,'{amount}','{discount}')";

                    var command = new SqlCommand(addQuer, dataBase.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Выберите новый товар либо завершите сделку", "Товар добавлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonConfirm.Enabled = true;
                    CreateColumnsProductContract();
                    RefreshDataGridContract(dataGridViewCatal);
                    TakeTotal();

            }
                else
                {
                    MessageBox.Show("Количество должно быть в виде числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
      

        }


        private void CreateColumnsProductContract()
        {
            dataGridViewCatal.Columns.Add("name", "Наименование");
            dataGridViewCatal.Columns.Add("amount", "Количество");
            dataGridViewCatal.Columns.Add("cost", "Итого");

        }

        private void ReadSingleRowContract(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetInt32(2));
        }

        private void RefreshDataGridContract(DataGridView dgv)
        {
            dgv.Rows.Clear();
            var buyerSerial = textBoxSerial.Text;
            string queryString = $"select product.name, body.amount, " +
                $"((product.cost*body.amount)-((product.cost*body.amount)/100*body.discount)) from body " +
                $"inner join upper on body.upper_id = upper.id " +
                $"inner join product on product.id = body.product_id where upper.serial = '{buyerSerial}';";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowContract(dgv, reader);
            }
            reader.Close();
        }


        private void TakeTotal()
        {
            var buyerSerial = textBoxSerial.Text;
            string commText1 = $"select  SUM((product.cost*body.amount)-((product.cost*body.amount)/100*body.discount)) as SUM " +
                $"from body  inner join upper on body.upper_id = upper.id inner join product on product.id = body.product_id" +
                $" where upper.serial = '{buyerSerial}';";

            SqlCommand command = new SqlCommand(commText1, dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            int total = reader.GetInt32("SUM");
            textBoxTotal.Text = total.ToString();

            reader.Close();
        }

        private void TotalSend()
        {
            var buyerSerial = textBoxSerial.Text;
            var total = textBoxTotal.Text;
            Convert.ToInt32(total.ToString());
            var changeQuery = $"update upper set price='{total}' where serial = '{buyerSerial}';";

            var command = new SqlCommand(changeQuery, dataBase.getConnection());

            command.ExecuteNonQuery();
        }


        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            TotalSend();
            this.Close();

        }
    }
}

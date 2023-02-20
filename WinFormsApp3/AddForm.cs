using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class AddForm : Form
    {
        DataBase dataBase = new DataBase();

        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = textBoxName.Text;

            int cost;

            if (int.TryParse(textBoxCost.Text, out cost))
            {
                var addQuer = $"insert into product (name, cost) values (N'{name}', '{cost}')";

                var command = new SqlCommand(addQuer, dataBase.getConnection());
                
                command.ExecuteNonQuery();

                MessageBox.Show("Введите количество товара", "Товар добавлен", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Size = new Size(477, 250);
                textBoxAmount.Visible = true;
                buttonConfirm.Visible = true;



            }
            else
            {
                MessageBox.Show("Цена должна быть в виде числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void newProduct()
        {
            var name = textBoxName.Text;

            var searchQuery = $"select id from product where name = N'{name}'";

            var commandSearch = new SqlCommand(searchQuery, dataBase.getConnection());

            SqlDataReader reader = commandSearch.ExecuteReader();

            reader.Read();
            var id = reader.GetInt32(0);
            reader.Close();

            int amount;

            int reserve = 0;


            if (int.TryParse(textBoxAmount.Text, out amount))
            {
                var addQuer = $"insert into warehouse (product_id, amount, amount_reserve) values ('{id}', '{amount}' , '{reserve}')";

                var command = new SqlCommand(addQuer, dataBase.getConnection());

                command.ExecuteNonQuery();

                MessageBox.Show("Товар добавлен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataBase.closeConnection();

            }
            else
            {
                MessageBox.Show("Количество быть в виде числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            newProduct();
            this.Close();
        }
    }
}

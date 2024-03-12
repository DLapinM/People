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
using System.Data.OleDb;

namespace People
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button_connect_db.Enabled = true;
            button_disconnect_db.Enabled = false;
            button_show_men_data.Enabled = false;
            button_show_women_data.Enabled = false;
            button_assign_changing_for_man_row.Enabled = false;
            button_assign_changing_for_woman_row.Enabled = false;
            button_add_man.Enabled = false;
            button_add_woman.Enabled = false;
            button_delete_man_row.Enabled = false;
            button_delete_woman_row.Enabled = false;
        }

        SqlConnection connection = new SqlConnection();
        
        private void button_connect_db_Click(object sender, EventArgs e)
        {
            Form_connecting_db f_c_db = new Form_connecting_db();

            f_c_db.ShowDialog();

            if (f_c_db.DialogResult == DialogResult.OK)
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.ConnectionString = DataStatic.str_connect;
                        connection.Open();

                        button_connect_db.Enabled = false;
                        button_disconnect_db.Enabled = true;
                        button_show_men_data.Enabled = true;
                        button_show_women_data.Enabled = true;

                        MessageBox.Show("Соединение с базой данных выполнено успешно");
                    }
                    else
                    {
                        MessageBox.Show("Соединение с базой данных уже установлено");
                    }
                }
                catch (OleDbException XcpSQL)
                {
                    foreach (OleDbError se in XcpSQL.Errors)
                    {
                        MessageBox.Show(se.Message, "SQL Error code " + se.NativeError, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception Xcp)
                {
                    MessageBox.Show(Xcp.Message, "Произошла непридвиденная ошибка. Установить соединение с базой данных не получилось.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_disconnect_db_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

                button_connect_db.Enabled = true;
                button_disconnect_db.Enabled = false;
                button_show_men_data.Enabled = false;
                button_show_women_data.Enabled = false;
                button_assign_changing_for_man_row.Enabled = false;
                button_assign_changing_for_woman_row.Enabled = false;
                button_add_man.Enabled = false;
                button_add_woman.Enabled = false;
                button_delete_man_row.Enabled = false;
                button_delete_woman_row.Enabled = false;

                dataGridView_men_data.DataSource = null;
                dataGridView_men_data.Rows.Clear();

                dataGridView_women_data.DataSource = null;
                dataGridView_women_data.Rows.Clear();

                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
            {
                MessageBox.Show("Соединение с базой данных уже закрыто");
            }
        }

        DataSet dataSet;

        public void men_list_refresh()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                @"use PeopleDB
                SELECT
                id,
                lastname as Фамилия,
                firstname as Имя,
                dbo.GetAge(birthday) as Возраст,
                birthday as ДатаРождения,
                country as Страна,
                city as Город,
                district as Район,
                CASE WHEN (marriage=0 AND dbo.Having_lover_for_man(id)=0) THEN 'Нет любимой' ELSE CASE WHEN marriage>0 THEN 'Женат' ELSE 'Есть любимая' END END as СтатусОтношений,
                COALESCE(CAST(dbo.GetGirlFriendNumber(id) as VARCHAR(255)), '-') as id_любимой,
                dbo.GetGirlFriendLastName(id) as ФамилияЛюбимой,
                dbo.GetGirlFriendName(id) as ИмяЛюбимой
                FROM MenCollection",
                DataStatic.str_connect);

            dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridView_men_data.DataSource = dataSet.Tables[0];

            dataGridView_men_data.Columns["id"].ReadOnly = true;
            dataGridView_men_data.Columns["Возраст"].ReadOnly = true;
            dataGridView_men_data.Columns["СтатусОтношений"].ReadOnly = true;
            dataGridView_men_data.Columns["id_любимой"].ReadOnly = true;
            dataGridView_men_data.Columns["ФамилияЛюбимой"].ReadOnly = true;
            dataGridView_men_data.Columns["ИмяЛюбимой"].ReadOnly = true;

            button_assign_changing_for_man_row.Enabled = true;
            button_add_man.Enabled = true;
            button_delete_man_row.Enabled = true;
        }
        private void button_show_men_data_Click(object sender, EventArgs e)
        {
            men_list_refresh();
        }

        private void sqlConnection1_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }

        DataSet dataSet2;

        public void women_list_refresh()
        {
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(
                @"use PeopleDB
                SELECT
                id,
                lastname as Фамилия,
                firstname as Имя,
                dbo.GetAge(birthday) as Возраст,
                birthday as ДатаРождения,
                country as Страна,
                city as Город,
                district as Район,
                CASE WHEN(marriage = 0 AND dbo.Having_lover_for_woman(id) = 0) THEN 'Нет любимого' ELSE CASE WHEN marriage > 0 THEN 'Замужем' ELSE 'Есть любимый' END END as СтатусОтношений,
                COALESCE(CAST(dbo.GetBoyFriendNumber(id) as VARCHAR(255)), '-') as id_любимого,
                dbo.GetBoyFriendLastName(id) as ФамилияЛюбимого,
                dbo.GetBoyFriendName(id) as ИмяЛюбимого
                FROM WomenCollection",
                DataStatic.str_connect);

            dataSet2 = new DataSet();

            dataAdapter2.Fill(dataSet2);

            dataGridView_women_data.DataSource = dataSet2.Tables[0];

            dataGridView_women_data.Columns["id"].ReadOnly = true;
            dataGridView_women_data.Columns["Возраст"].ReadOnly = true;
            dataGridView_women_data.Columns["СтатусОтношений"].ReadOnly = true;
            dataGridView_women_data.Columns["id_любимого"].ReadOnly = true;
            dataGridView_women_data.Columns["ФамилияЛюбимого"].ReadOnly = true;
            dataGridView_women_data.Columns["ИмяЛюбимого"].ReadOnly = true;

            button_assign_changing_for_woman_row.Enabled = true;
            button_add_woman.Enabled = true;
            button_delete_woman_row.Enabled = true;
        }

        private void button_show_women_data_Click(object sender, EventArgs e)
        {
            women_list_refresh();
        }

        private void button_assign_changing_for_man_row_Click(object sender, EventArgs e)
        {
            int index = dataGridView_men_data.CurrentCell.RowIndex;

            string m_id = dataGridView_men_data["id", index].Value.ToString();
            string m_lastname = dataGridView_men_data["Фамилия", index].Value.ToString();
            string m_firstname = dataGridView_men_data["Имя", index].Value.ToString();
            string m_birthday = dataGridView_men_data["ДатаРождения", index].Value.ToString();
            string m_country = dataGridView_men_data["Страна", index].Value.ToString();
            string m_city = dataGridView_men_data["Город", index].Value.ToString();
            string m_district = dataGridView_men_data["Район", index].Value.ToString();

            
            string str_command_row_man_update =
                @"use PeopleDB
                UPDATE MenCollection
                SET lastname = '" + m_lastname + @"' , 
                firstname = '" + m_firstname + @"' , 
                birthday = '" + m_birthday + @"' , 
                country = '" + m_country + @"' , 
                city = '" + m_city + @"' , 
                district = '" + m_district + @"' 
                WHERE id = " + m_id;
            

            SqlCommand command_row_man_update = new SqlCommand(str_command_row_man_update, connection);

            try
            {
                int q_str = command_row_man_update.ExecuteNonQuery();

                men_list_refresh();

                if (button_assign_changing_for_woman_row.Enabled)
                {
                    women_list_refresh();
                }

                MessageBox.Show(@"Изменения успешно внесены в базу даннных. Количество обработанных строк: " + q_str.ToString() + @".");
            }
            catch
            {
                MessageBox.Show(@"Возникла ошибка. Изменения в базу данных не внесены.");
            }
        }

        private void button_assign_changing_for_woman_Click(object sender, EventArgs e)
        {
            int index = dataGridView_women_data.CurrentCell.RowIndex;

            string w_id = dataGridView_women_data["id", index].Value.ToString();
            string w_lastname = dataGridView_women_data["Фамилия", index].Value.ToString();
            string w_firstname = dataGridView_women_data["Имя", index].Value.ToString();
            string w_birthday = dataGridView_women_data["ДатаРождения", index].Value.ToString();
            string w_country = dataGridView_women_data["Страна", index].Value.ToString();
            string w_city = dataGridView_women_data["Город", index].Value.ToString();
            string w_district = dataGridView_women_data["Район", index].Value.ToString();

            string str_command_row_woman_update =
                @"use PeopleDB
                UPDATE WomenCollection
                SET lastname = '" + w_lastname + @"' , 
                firstname = '" + w_firstname + @"' , 
                birthday = '" + w_birthday + @"' , 
                country = '" + w_country + @"' , 
                city = '" + w_city + @"' , 
                district = '" + w_district + @"' 
                WHERE id = " + w_id;

            SqlCommand command_row_woman_update = new SqlCommand(str_command_row_woman_update, connection);

            try
            {
                int q_str = command_row_woman_update.ExecuteNonQuery();

                women_list_refresh();

                if (button_assign_changing_for_man_row.Enabled)
                {
                    men_list_refresh();
                }

                MessageBox.Show(@"Изменения успешно внесены в базу даннных. Количество обработанных строк: " + q_str.ToString() + @".");
            }
            catch
            {
                MessageBox.Show(@"Возникла ошибка. Изменения в базу данных не внесены.");
            }
        }

        private void button_add_man_Click(object sender, EventArgs e)
        {
            Form_add_man f_add_man = new Form_add_man();

            f_add_man.ShowDialog();

            if (f_add_man.DialogResult == DialogResult.OK)
            {
                string str_add_man_command =
                    @"INSERT INTO MenCollection (lastname, firstname, birthday, country, city, district, marriage) VALUES ('" + DataStatic.add_man_lastname + @"', '" + DataStatic.add_man_firstname + @"', '" + DataStatic.add_man_birthday + @"', '" + DataStatic.add_man_country + @"', '" + DataStatic.add_man_city + @"', '" + DataStatic.add_man_district + @"', 0);";
                
                SqlCommand add_man_command = new SqlCommand(str_add_man_command, connection);

                try
                {
                    int q_str = add_man_command.ExecuteNonQuery();

                    men_list_refresh();

                    if (button_assign_changing_for_woman_row.Enabled)
                    {
                        women_list_refresh();
                    }

                    MessageBox.Show(@"Изменения успешно внесены в базу даннных. Количество обработанных строк: " + q_str.ToString() + @".");
                }
                catch
                {
                    MessageBox.Show(@"Возникла ошибка. Изменения в базу данных не внесены.");
                }
            }
        }

        private void button_add_woman_Click(object sender, EventArgs e)
        {
            Form_add_woman f_add_woman = new Form_add_woman();

            f_add_woman.ShowDialog();

            if (f_add_woman.DialogResult == DialogResult.OK)
            {
                string str_add_woman_command =
                    @"INSERT INTO WomenCollection (lastname, firstname, birthday, country, city, district, marriage) VALUES ('" + DataStatic.add_woman_lastname + @"', '" + DataStatic.add_woman_firstname + @"', '" + DataStatic.add_woman_birthday + @"', '" + DataStatic.add_woman_country + @"', '" + DataStatic.add_woman_city + @"', '" + DataStatic.add_woman_district + @"', 0);";

                SqlCommand add_woman_command = new SqlCommand(str_add_woman_command, connection);

                try
                {
                    int q_str = add_woman_command.ExecuteNonQuery();

                    women_list_refresh();

                    if (button_assign_changing_for_man_row.Enabled)
                    {
                        men_list_refresh();
                    }

                    MessageBox.Show(@"Изменения успешно внесены в базу даннных. Количество обработанных строк: " + q_str.ToString() + @".");
                }
                catch
                {
                    MessageBox.Show(@"Возникла ошибка. Изменения в базу данных не внесены.");
                }
            }
        }

        private void button_delete_man_row_Click(object sender, EventArgs e)
        {
            int index = dataGridView_men_data.CurrentCell.RowIndex;

            string m_id = dataGridView_men_data["id", index].Value.ToString();

            string str_delete_man_row =
                @"DECLARE @m_id INT
	            DECLARE @w_id INT
	            DECLARE @brak INT

	            SET @m_id = " + m_id + @" 

	            SET @w_id = dbo.GetGirlFriendNumber(@m_id)

	            IF (@w_id IS NULL)
	            BEGIN
		            DELETE FROM MenCollection
		            WHERE id = @m_id
	            END
	            ELSE
	            BEGIN
		            SET @brak =
			            (SELECT
			            marriage
			            FROM MenCollection
			            WHERE id = @m_id)

			            IF (@brak > 0)
			            BEGIN
                            BEGIN TRANSACTION

                            UPDATE WomenCollection
				            SET marriage = 0
				            WHERE id = @w_id

                            UPDATE MenCollection
				            SET marriage = 0
				            WHERE id = @m_id

				            DELETE FROM Lovers
				            WHERE man_id = @m_id

				            DELETE FROM MenCollection
				            WHERE id = @m_id

                            COMMIT TRANSACTION
			            END
			            ELSE
			            BEGIN
                            BEGIN TRANSACTION

				            DELETE FROM Lovers
				            WHERE man_id = @m_id

				            DELETE FROM MenCollection
				            WHERE id = @m_id

                            COMMIT TRANSACTION
			            END
	            END";

            SqlCommand command_delete_man_row = new SqlCommand(str_delete_man_row, connection);

            try
            {
                int q_str = command_delete_man_row.ExecuteNonQuery();

                men_list_refresh();

                if (button_assign_changing_for_woman_row.Enabled)
                {
                    women_list_refresh();
                }

                MessageBox.Show(@"Изменения успешно внесены в базу даннных.");
            }
            catch
            {
                MessageBox.Show(@"Возникла ошибка. Изменения в базу данных не внесены.");
            }
        }

        private void button_delete_woman_row_Click(object sender, EventArgs e)
        {
            int index = dataGridView_women_data.CurrentCell.RowIndex;

            string w_id = dataGridView_women_data["id", index].Value.ToString();

            string str_delete_woman_row =
                @"DECLARE @w_id INT
	            DECLARE @m_id INT
	            DECLARE @brak INT

	            SET @w_id = " + w_id + @" 

	            SET @m_id = dbo.GetBoyFriendNumber(@w_id)

	            IF (@m_id IS NULL)
	            BEGIN
		            DELETE FROM WomenCollection
		            WHERE id = @w_id
	            END
	            ELSE
	            BEGIN
		            SET @brak =
			            (SELECT
			            marriage
			            FROM WomenCollection
			            WHERE id = @w_id)

			            IF (@brak > 0)
			            BEGIN
				            BEGIN TRANSACTION

				            DELETE FROM Lovers
				            WHERE woman_id = @w_id

				            DELETE FROM WomenCollection
				            WHERE id = @w_id

				            UPDATE MenCollection
				            SET marriage = 0
				            WHERE id = @m_id

				            COMMIT TRANSACTION
			            END
			            ELSE
			            BEGIN
				            BEGIN TRANSACTION

				            DELETE FROM Lovers
				            WHERE woman_id = @w_id

				            DELETE FROM WomenCollection
				            WHERE id = @w_id

				            COMMIT TRANSACTION
			            END
	            END";

            SqlCommand command_delete_woman_row = new SqlCommand(str_delete_woman_row, connection);

            try
            {
                int q_str = command_delete_woman_row.ExecuteNonQuery();

                women_list_refresh();

                if (button_assign_changing_for_man_row.Enabled)
                {
                    men_list_refresh();
                }

                MessageBox.Show(@"Изменения успешно внесены в базу даннных.");
            }
            catch
            {
                MessageBox.Show(@"Возникла ошибка. Изменения в базу данных не внесены.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    public partial class Form_connecting_db : Form
    {
        public Form_connecting_db()
        {
            InitializeComponent();

            textBox_server_name.Text = DataStatic.last_server_name;
            textBox_db_name.Text = DataStatic.last_db_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_server_name.Text == "") MessageBox.Show("Ошибка! Вы не указали имя сервера!");
            if (textBox_db_name.Text == "") MessageBox.Show("Ошибка! Вы не указали имя базы данных!");

            if ((textBox_server_name.Text != "") && (textBox_db_name.Text != ""))
            {
                DataStatic.str_connect = @"Data Source=" + textBox_server_name.Text + @";Initial Catalog=" + textBox_db_name.Text + @";Integrated Security=True";

                DataStatic.last_server_name = textBox_server_name.Text;
                DataStatic.last_db_name = textBox_db_name.Text;

                this.Close();
            }
        }
    }
}

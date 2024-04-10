using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            if (textBoxAuthPassword.PasswordChar == '*')
            {
                textBoxAuthPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxAuthPassword.PasswordChar = '*';
            }
        }

        private void buttonAuthEnter_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM auth WHERE `Login` = @login and `Password` = @password", conn);
            conn.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            cmd.Parameters.AddWithValue("login", textBoxAuthLogin.Text);
            cmd.Parameters.AddWithValue("password", textBoxAuthPassword.Text);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            int levelOfAccess;
            if (table.Rows.Count > 0)
            {
                //hide_all_windows();
                string welcomemsg = "";
                levelOfAccess = Convert.ToInt32(table.Rows[0].ItemArray[3]);
                using (MySqlCommand fetchNames = new MySqlCommand("SELECT * FROM Users WHERE `ID_User`=" + Convert.ToString(table.Rows[0].ItemArray[2])))
                {
                    fetchNames.Connection = conn;
                    fetchNames.CommandType = CommandType.Text;
                    using (DataTable tableNames = new DataTable())
                    {
                        using (MySqlDataAdapter sdaNames = new MySqlDataAdapter(fetchNames))
                        {
                            sdaNames.Fill(tableNames);
                            welcomemsg = "Добро пожаловать!";
                        }
                    }
                }
                textBoxAuthLogin.Text = "";
                textBoxAuthPassword.Text = "";
                switch (levelOfAccess)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
                MessageBox.Show(welcomemsg, "Приветствие", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль, пожалуйста, попробуйте снова или обратитесь к администратору", "Ошибка авторизации", MessageBoxButtons.OK);
            }
        }
    }
}

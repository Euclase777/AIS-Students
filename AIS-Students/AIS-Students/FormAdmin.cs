using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AIS_Students
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        public class StringItemWithOldID
        {
            public int OldID;
            public string text;
            public override string ToString()
            {
                return this.text;
            }
        }

        private void buttonGroupCreateAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите создать новый заказ используя введенные данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO groups (Class, `Group`, Faculty) VALUES (@class, @group, @faculty)", conn);
                cmd.Parameters.AddWithValue("class", textBoxGroupClassAdmin.Text);
                cmd.Parameters.AddWithValue("group", textBoxGroupNameAdmin.Text);
                cmd.Parameters.AddWithValue("faculty", textBoxGroupFacultyAdmin.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonGroupAdmin.PerformClick();
            }
        }

        private void buttonGroupAdmin_Click(object sender, EventArgs e)
        {
            panelGroupAdmin.Visible = true;
            panelServicesAdministrator.Visible = false;
            panelStorageAdministrator.Visible = false;
            panelWorkersAdministrator.Visible = false;
            panelAuthorizationAdministrator.Visible = false;
            textBoxGroupNameAdmin.Text = "";
            textBoxGroupFacultyAdmin.Text = "";
            textBoxGroupClassAdmin.Text = "";
            MySqlConnection conn = DBUtils.GetDBConnection();
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Group, `Group`, Faculty, Class FROM groups", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewGroupAdmin.DataSource = dt;
                        dataGridViewGroupAdmin.Columns[0].Visible = false;
                    }
                }
            }

        }

        private void buttonGroupDeleteAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранный заказ?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM groups WHERE ID_Group = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewGroupAdmin.CurrentRow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                buttonGroupAdmin.PerformClick();
            }
        }

        private void buttonStudentsAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}

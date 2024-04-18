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
            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить группу, используя введенные данные?", "Подтверждение", MessageBoxButtons.YesNo);
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
            panelAdminsAdmin.Visible = false;
            panelStudentAdmin.Visible = false;
            panelTeachersAdmin.Visible = false;
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
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранную группу?", "Подтверждение", MessageBoxButtons.YesNo);
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
            panelGroupAdmin.Visible = false;
            panelTeachersAdmin.Visible = false;
            panelStudentAdmin.Visible = true;
            textBoxStudentNameAdmin.Text = "";
            checkedListBoxGroupStudentAdmin.Items.Clear();
            MySqlConnection conn = DBUtils.GetDBConnection();
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Group,CONCAT(Faculty,'-',`Group`) FROM groups", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            checkedListBoxGroupStudentAdmin.Items.Add(new StringItemWithOldID()
                            {
                                OldID = Convert.ToInt16(row[0]),
                                text = Convert.ToString(row[1])
                            });
                        }
                    }
                }
            }
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Student, FIO as `ФИО студента`, CONCAT(Faculty,'-',`Group`) as `Группа`\r\nFROM students\r\nJOIN groups ON students.ID_Group = groups.ID_Group;", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewStudentAdmin.DataSource = dt;
                        dataGridViewStudentAdmin.Columns[0].Visible = false;
                    }
                }
            }

        }

        private void dataGridViewStudentAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (int i in checkedListBoxGroupStudentAdmin.CheckedIndices)
            {
                checkedListBoxGroupStudentAdmin.SetItemCheckState(i, CheckState.Unchecked);
            }
            if (Convert.ToString(dataGridViewStudentAdmin.CurrentRow.Cells[0].Value) != "")
            {
                
                textBoxStudentNameAdmin.Text = Convert.ToString(dataGridViewStudentAdmin.CurrentRow.Cells[1].Value);
                for(int i = 0; i < checkedListBoxGroupStudentAdmin.Items.Count; i++)
                {
                    if (Convert.ToString(dataGridViewStudentAdmin.CurrentRow.Cells[2].Value) == Convert.ToString(checkedListBoxGroupStudentAdmin.Items[i]))
                    {
                        checkedListBoxGroupStudentAdmin.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void checkedListBoxGroupStudentAdmin_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBoxGroupStudentAdmin.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBoxGroupStudentAdmin.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void buttonStudentDeleteAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранного студента из списка?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM students.students WHERE ID_Student = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewStudentAdmin.CurrentRow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                buttonStudentsAdmin.PerformClick();
            }
        }

        private void buttonStudentCreateAdmin_Click(object sender, EventArgs e)
        {
            if (checkedListBoxGroupStudentAdmin.CheckedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить нового студента?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = DBUtils.GetDBConnection();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO students (FIO, ID_Group) VALUES (@name, @id)", conn);
                    cmd.Parameters.AddWithValue("name", textBoxStudentNameAdmin.Text);
                    foreach (StringItemWithOldID item in checkedListBoxGroupStudentAdmin.CheckedItems)
                    {
                        cmd.Parameters.AddWithValue("id", item.OldID.ToString());
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    buttonStudentsAdmin.PerformClick();
                }
            }
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonTeachersAdmin_Click(object sender, EventArgs e)
        {
            panelStudentAdmin.Visible = false;
            panelAdminsAdmin.Visible = false;
            panelGroupAdmin.Visible = false;
            panelTeachersAdmin.Visible = true;
            textBoxTeacherFIOAdmin.Text = "";
            MySqlConnection conn = DBUtils.GetDBConnection();
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Teacher, FIO as `ФИО` FROM teachers", conn))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewTeacherAdmin.DataSource = dt;
                        dataGridViewTeacherAdmin.Columns[0].Visible = false;
                    }
                }
            }
        }

        private void dataGridViewWorkersAdministrator_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(dataGridViewTeacherAdmin.CurrentRow.Cells[0].Value) != "")
            {
                textBoxTeacherFIOAdmin.Text = Convert.ToString(dataGridViewTeacherAdmin.CurrentRow.Cells[1].Value);
            }
            else
            {
                textBoxTeacherFIOAdmin.Text = "";
            }
        }

        private void buttonWorkersCreateAdministrator_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить учителя, используя введенные данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO teachers (FIO) VALUES (@fio)", conn);
                cmd.Parameters.AddWithValue("fio", textBoxTeacherFIOAdmin.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonTeachersAdmin.PerformClick();
            }
        }

        private void buttonTeacherDeleteAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранного учителя?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM teachers WHERE ID_Teacher = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewTeacherAdmin.CurrentRow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                buttonTeachersAdmin.PerformClick();
            }
        }

        private void buttonTeacherEditAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить данные выбранного учителя?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE teachers SET FIO = @fio WHERE ID_Teacher = @ID", conn);
                cmd.Parameters.AddWithValue("fio", textBoxTeacherFIOAdmin.Text);
                cmd.Parameters.AddWithValue("ID", Convert.ToString(dataGridViewTeacherAdmin.CurrentRow.Cells[0].Value));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonTeachersAdmin.PerformClick();
            }
        }

        private void buttonAdminAdmin_Click(object sender, EventArgs e)
        {
            panelStudentAdmin.Visible = false;
            panelAdminsAdmin.Visible = true;
            panelGroupAdmin.Visible = false;
            panelTeachersAdmin.Visible = false;
            textBoxAdminsFIOAdmin.Text = "";
            MySqlConnection conn = DBUtils.GetDBConnection();
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Sysadmin, FIO as `ФИО` FROM sysadmins", conn))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewAdminsAdmin.DataSource = dt;
                        dataGridViewAdminsAdmin.Columns[0].Visible = false;
                    }
                }
            }
        }

        private void dataGridViewAdminsAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(dataGridViewAdminsAdmin.CurrentRow.Cells[0].Value) != "")
            {
                textBoxAdminsFIOAdmin.Text = Convert.ToString(dataGridViewAdminsAdmin.CurrentRow.Cells[1].Value);
            }
            else
            {
                textBoxAdminsFIOAdmin.Text = "";
            }
        }

        private void buttonAdminsAddAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить администратора, используя введенные данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO sysadmins (FIO) VALUES (@fio)", conn);
                cmd.Parameters.AddWithValue("fio", textBoxAdminsFIOAdmin.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonAdminAdmin.PerformClick();
            }
        }

        private void buttonAdminsEditAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить данные выбранного администратора?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE sysadmins SET FIO = @fio WHERE ID_Sysadmin = @ID", conn);
                cmd.Parameters.AddWithValue("fio", textBoxAdminsFIOAdmin.Text);
                cmd.Parameters.AddWithValue("ID", Convert.ToString(dataGridViewAdminsAdmin.CurrentRow.Cells[0].Value));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonAdminAdmin.PerformClick();
            }
        }

        private void buttonAdminsDeleteAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранного администратора?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM sysadmins WHERE ID_Sysadmin = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewAdminsAdmin.CurrentRow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonAdminAdmin.PerformClick();
            }
        }
    }
}

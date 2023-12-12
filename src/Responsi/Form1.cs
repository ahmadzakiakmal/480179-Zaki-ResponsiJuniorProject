using Npgsql;
using System.Data;

namespace Responsi
{
    public partial class Form1 : Form
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsizaki";
        NpgsqlConnection conn;
        string sql;
        NpgsqlCommand cmd;
        public DataTable dt;
        private DataGridViewRow row;

        public DataGridViewRow Row { get => row; set => row = value; }

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                sql = "select * from karyawan, departemen WHERE karyawan.id_dep = departemen.id_dep;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDataTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void InsertData()
        {
            string nama = TbNama.Text;
            int id_dep = 0;

            if (RbHR.Checked)
            {
                id_dep = 1;

            }
            else if (RbENG.Checked)
            {
                id_dep = 2;

            }
            else if (RbDEV.Checked)
            {
                id_dep = 3;
            }
            else if (RbPM.Checked)
            {
                id_dep = 4;
            }
            else if (RbFIN.Checked)
            {
                id_dep = 5;
            }

            if (id_dep == 0)
            {
                MessageBox.Show("Pilih departemen");
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM add_karyawan(@in_id_karyawan, @in_nama, @in_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", nama + id_dep.ToString());
                cmd.Parameters.AddWithValue("@in_nama", nama);
                cmd.Parameters.AddWithValue("@in_id_dep", id_dep);
                int statusCode = (int)cmd.ExecuteScalar();
                if (statusCode == 201)
                {
                    MessageBox.Show("[201] Created");
                    LoadData();
                    return;
                }
                if (statusCode == 409)
                {
                    throw new Exception("[409] User already exist");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            finally { conn.Close(); }
        }

        private void EditData()
        {
            if (Row == null)
            {
                MessageBox.Show("Pilih karyawan untuk diedit", "Ingfo");
                return;
            }
            try
            {
                string nama = TbNama.Text;
                int id_dep = 0;

                if (RbHR.Checked)
                {
                    id_dep = 1;

                }
                else if (RbENG.Checked)
                {
                    id_dep = 2;

                }
                else if (RbDEV.Checked)
                {
                    id_dep = 3;
                }
                else if (RbPM.Checked)
                {
                    id_dep = 4;
                }
                else if (RbFIN.Checked)
                {
                    id_dep = 5;
                }

                if (id_dep == 0)
                {
                    MessageBox.Show("Pilih departemen");
                    return;
                }

                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM edit_karyawan(@in_id_karyawan, @in_nama, @in_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", Row.Cells["id_karyawan"].Value);
                cmd.Parameters.AddWithValue("@in_nama", nama);
                cmd.Parameters.AddWithValue("@in_id_dep", id_dep);

                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 200)
                {
                    MessageBox.Show("[200] Edit success", "Success");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception("[404] karyawan tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void DeleteData()
        {
            if (Row == null)
            {
                MessageBox.Show("Pilih karyawan untuk dihapus", "Ingfo");
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT * FROM delete_karyawan(@in_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", Row.Cells["id_karyawan"].Value);

                int statusCode = (int)cmd.ExecuteScalar();

                if (statusCode == 204)
                {
                    MessageBox.Show("[204] Delete success", "Success");
                    LoadData();
                    return;
                }
                if (statusCode == 404)
                {
                    throw new Exception("[404] Karyawan tidak ditemukan");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void dgvDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Row = dgvDataTable.Rows[e.RowIndex];
                LbSelected.Text = Row.Cells["id_karyawan"].Value.ToString();
                TbNama.Text = Row.Cells["nama"].Value.ToString();
                int id_dep = (int)Row.Cells["id_dep"].Value;

                if (id_dep == 1) RbHR.Checked = true;
                else if (id_dep == 2) RbENG.Checked = true;
                else if (id_dep == 3) RbDEV.Checked = true;
                else if (id_dep == 4) RbPM.Checked = true;
                else if (id_dep == 5) RbFIN.Checked = true;
                else
                {
                    throw new Exception("An error occured");
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }
    }
}
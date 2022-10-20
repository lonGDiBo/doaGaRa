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
using System.Runtime.InteropServices;
namespace giaodien
{
    public partial class Form1 : Form
    {
        public string ten = "";
        public string chucvu = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot_password form4 = new Forgot_password();
            form4.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up form2 = new Sign_up();
            form2.ShowDialog();
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            string acc = txt_nameacc.Text;
            string a = "select acc,pass from DANGNHAP where acc='" + acc + "'";
            DataTable b = db.Execute(a);
            if (b.Rows.Count == 0)
                MessageBox.Show("Không có tên đăng nhập này", "Thông báo", MessageBoxButtons.OK);
            else
            {
                string query = "select * from DANGNHAP where acc='" + txt_nameacc.Text + "' and pass='" + txt_pass.Text + "'";
                DataTable tb = db.Execute(query);
                if (tb.Rows.Count==0)
                    MessageBox.Show("Mật khẩu sai", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    this.Hide();
                    Form_Chinh form3 = new Form_Chinh();
                    string query3 = " acc='" + txt_nameacc.Text + "'";
                    GarageDB gr = new GarageDB();
                    DataTable tb1 = gr.LayBangDK(query3, gr.DN);
                    this.ten = tb1.Rows[0][2].ToString();
                    this.chucvu= tb1.Rows[0][3].ToString();
                    form3.ShowDialog();
                    this.Close();
                }
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show.Checked == true)
                txt_pass.UseSystemPasswordChar = false;
            else
                txt_pass.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

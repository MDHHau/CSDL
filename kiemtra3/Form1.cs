using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemtra3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;

        private void Connect()
        {
            
            string strConn = "server=LAPTOP-J3041A65\\SQLEXPRESS;database=qldh;Integrated Security=True";
            con = new SqlConnection(strConn);


            try
            {
                con.Open();
                // MessageBox.Show("Ket noi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }


        }
        private void loaddata()
        {
            Connect();
            SqlDataAdapter da = new SqlDataAdapter("select * from donhang", con);
            DataTable dt = new DataTable();
          
            da.Fill(dt);
            dataqldonhang.DataSource = dt;
            con.Close();
        }
        private void xoadata()
        {
            txtsanpham.Text = String.Empty;
            txtkhach.Text = String.Empty;
            txtsoluong.Text = String.Empty;
            txtgia.Text = String.Empty;
            txttimkiem.Text = String.Empty;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
            xoadata();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            Connect() ;
             SqlCommand cmd = new SqlCommand("insert into donhang values('" + txtsanpham.Text + "','" + txtkhach.Text + "','" + Convert.ToDouble(txtsoluong.Text) + "','" + Convert.ToInt16(txtgia.Text) + "')", con);
            
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
                MessageBox.Show("them ok");
            con.Close();
            txtsanpham.Focus();
            loaddata();
            xoadata();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("update donhang set khachhang='" + txtkhach.Text + "',soluong='" + Convert.ToInt16(txtsoluong.Text) + "',gia='" + Convert.ToDouble(txtgia.Text) + "'where sanpham='" + txtsanpham.Text + "'", con);
            
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
                MessageBox.Show("Cap nhat ok: :))");
            con.Close();
            loaddata();
            xoadata();
        }

        private void dataqldonhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsanpham.Text = dataqldonhang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkhach.Text = dataqldonhang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoluong.Text = dataqldonhang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtgia.Text = dataqldonhang.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            Connect();
             DialogResult result = MessageBox.Show("Ban co chắn chắn?", "Xoá bản ghi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from donhang where khachhang= '" + txtkhach.Text + "'", con);
               
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show("xoa ok");

                con.Close();
                loaddata();
                xoadata();
            }
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            Connect();
             SqlDataAdapter da = new SqlDataAdapter("select * from donhang where khachhang LIKE '%" + txttimkiem.Text + "%' and soluong ='"+txtsoluong.Text+"'  " , con);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            dataqldonhang.DataSource = dt;
            con.Close();
        }
    }
}

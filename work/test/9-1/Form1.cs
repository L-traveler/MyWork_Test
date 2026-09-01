using MySqlConnector;
using System.Data;

namespace WinFormsAppTest9_1
{
    public partial class Form1 : Form
    {
        string ConStr = "server=127.0.0.1;port=3306;database=test01;uid=root;pwd=root;charset=utf8";
        public Form1()
        {
            InitializeComponent();

            using (MySqlConnection MysqlConn = new MySqlConnection(ConStr))
            {
                MysqlConn.Open();
                string sql = "select * from user";
                using (MySqlCommand cmd = new MySqlCommand(sql, MysqlConn))
                {
                    MySqlDataAdapter Adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    Adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            using (MySqlConnection MysqlConn = new MySqlConnection(ConStr))
            {
                MysqlConn.Open();
                string sql = "select * from user where userName=@name";
                using (MySqlCommand cmd = new MySqlCommand(sql, MysqlConn))
                {
                    cmd.Parameters.AddWithValue("@name", str);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataGridView = new DataTable();
                    adapter.Fill(dataGridView);
                    dataGridView1.DataSource = dataGridView;


                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection MysqlConn = new MySqlConnection(ConStr))
            {
                MysqlConn.Open();
                string sql = "update user set userName=@name,password=@pwd,age=@age,gender=@gender where id=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql, MysqlConn))
                {
                    cmd.Parameters.AddWithValue("@id", 12);
                    cmd.Parameters.AddWithValue("@name", "小明");
                    cmd.Parameters.AddWithValue("@pwd", "123123");
                    cmd.Parameters.AddWithValue("@age", 19);
                    cmd.Parameters.AddWithValue("@gender", "男");
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection MysqlConn = new MySqlConnection(ConStr))
            {

                MysqlConn.Open();
                string sql = "select count(*) from user";
                using (MySqlCommand cmd = new MySqlCommand(sql, MysqlConn))
                {
                    //获取聚合查询结果
                    object res = cmd.ExecuteScalar();

                    label1.Text = res.ToString();

                    

                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection MysqlConn = new MySqlConnection(ConStr))
            {

                MysqlConn.Open();
                string sql = "select * from user where id=4";
                using (MySqlCommand cmd = new MySqlCommand(sql, MysqlConn))
                {
                   
                    //获取读取结果对象
                    MySqlDataReader reader = cmd.ExecuteReader();

                    label2.Text=reader.FieldCount.ToString();
                    label3.Text=reader.HasRows.ToString();

                    bool isrow=reader.Read();
                    if (isrow)
                    {
                        label4.Text = reader.GetString("username");
                    }
                    else
                    {
                        label4.Text = "无";
                    }
                    
                }


            }
        }
    }
}

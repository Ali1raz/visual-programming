namespace student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username == "aliraza" && password =="3456")
            {
                this.Hide();
                Form2 form = new Form2();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid name or password");
            }
        }
    }
}

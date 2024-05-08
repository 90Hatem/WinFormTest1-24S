namespace WinFormTest1
{
    public partial class Form1 : Form
    {
        TextBox[] textBoxes = new TextBox[4];
        public Form1()
        {
            InitializeComponent();

            textBoxes[0] = textBox1;
            textBoxes[1] = textBox2;
            textBoxes[2] = textBox3;
            textBoxes[3] = textBox4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            textBox2.Text = textBox3.Text;
            textBox3.Text = textBox4.Text;
            textBox4.Text = textBox1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox4.Text;
            textBox4.Text = textBox3.Text;
            textBox3.Text = textBox2.Text;
            textBox2.Text = textBox1.Text;
        }
    }
}

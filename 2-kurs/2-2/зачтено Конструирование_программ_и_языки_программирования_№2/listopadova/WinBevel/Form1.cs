using Bevel;
namespace WinBevel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bevelControl1.BevelStyle = BevelStyle.Raised;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bevelControl1.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bevelControl1.Left=300;
        }
    }
}
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        private List<PictureBox> holes;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            holes = new() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox8.Location = holes[new Random().Next(holes.Count)].Location;
            pictureBox8.Visible = true;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            score++;
            label1.Text = "SCORE: " + score.ToString();
            pictureBox8.Visible = false;
        }
    }
}
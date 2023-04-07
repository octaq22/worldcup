using System.Media;

namespace world_cup
{
    public partial class Form1 : Form
    {
        private void playaudio1()
        {
            SoundPlayer audio = new SoundPlayer(world_cup.Properties.Resources.REFEREE_WHISTLE_SOUND_EFFECT);
            audio.Play();
        }

        public Form1()
        {
            InitializeComponent();
            label2.Hide();  
            pictureBox1.Hide();
            playaudio1();
        }
        private void playaudio2()
        {
            SoundPlayer audio2 = new SoundPlayer(world_cup.Properties.Resources.final);
            audio2.Play();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(769, this.ClientSize.Width - button2.Width);
            int y = rand.Next(367, this.ClientSize.Height - button2.Height);
            button2.Location = new Point(x, y);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            playaudio1();
            button1.Hide();
            button2.Hide();
            label2.Show();
            playaudio2();
            await Task.Delay(10000);
            label2.Hide();
            pictureBox1.Show();
        }
    }
}
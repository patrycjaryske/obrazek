namespace obrazek
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Bitmap Images|*.bmp" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Image = originalImage;
                }
            }
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if(originalImage != null)
            {
                if (radioButton90.Checked)
                {
                    originalImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (radioButton180.Checked)
                {
                    originalImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (radioButton270.Checked)
                {
                    originalImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
            }
            pictureBox1.Image = originalImage;
            pictureBox1.Refresh();
        }
    }
}

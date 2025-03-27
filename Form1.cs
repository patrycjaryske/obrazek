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
            if (originalImage != null)
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

        private void InvertColors_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Bitmap invertedImage = new Bitmap(originalImage);
            for (int y = 0;  y < invertedImage.Height;y++ )
            {
                for (int x = 0; x < invertedImage.Width;x++ )
                {
                    Color pixel = invertedImage.GetPixel(x, y);
                    Color invertedPixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 -pixel.B);
                    invertedImage.SetPixel(x, y, invertedPixel);
                }
            }
            pictureBox1.Image = invertedImage;
        }

        private void Upsidedown_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                originalImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Image = originalImage;
                pictureBox1.Refresh();
            }
            

        }
    }
}

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

        private void OnlyGreen_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            Bitmap greenImage = new Bitmap(originalImage);
            for (int y = 0; y < greenImage.Height; y++)
            {
                for (int x = 0; x < greenImage.Width; x++)
                {
                    Color pixel = greenImage.GetPixel(x, y);
                    if(pixel.G < pixel.R || pixel.G < pixel.B)
                    {
                        greenImage.SetPixel(x, y, Color.Black);
                    }
                }
            }
            pictureBox1.Image = greenImage;
        }
    }


}

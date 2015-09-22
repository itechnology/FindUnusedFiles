using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ITechnologyNET.FindUnusedFiles
{
    public partial class PictureBox : Form
    {
        public PictureBox(int width, int height)
        {
            InitializeComponent();

            LostFocus += (s, o) => Hide();

            Size = new Size(width, height);
            pictureBox1.Size = Size;
        }

        public void DisplayImage(string path)
        {
            if (Regex.IsMatch(path, @"\.(gif|jpg|jpeg|png|bmp|ico|wmf)$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
            {
                pictureBox1.ImageLocation = path;
                StartPosition             = FormStartPosition.Manual;
                //Location                  = new Point(MousePosition.X + 15, MousePosition.Y - 150);

                Show();
            }
            else
            {
                Hide();
            }
        }
    }
}

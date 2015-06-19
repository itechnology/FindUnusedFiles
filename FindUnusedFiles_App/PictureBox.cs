using System.Drawing;
using System.Windows.Forms;

namespace ITechnologyNET.FindUnusedFiles
{
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
            LostFocus += (s, o) => Hide();
        }

        public void DisplayImage(string path)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(path, @"\.(gif|jpg|jpeg|png|bmp|ico|wmf)$"))
            {
                pictureBox1.ImageLocation = path;
                StartPosition             = FormStartPosition.Manual;
                Location                  = new Point(MousePosition.X + 15, MousePosition.Y - 150);

                Show();
            }
            else
            {
                Hide();
            }            
        }
    }
}

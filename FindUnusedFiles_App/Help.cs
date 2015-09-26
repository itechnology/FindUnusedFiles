using System.Reflection;
using System.Windows.Forms;

namespace ITechnologyNET.FindUnusedFiles
{
    partial class Help : Form
    {
        public Help(string which = "license")
        {
            InitializeComponent();

            switch (which)
            {
                default:
                    Text              = @"License";
                    richTextBox1.Text = Properties.Resources.license_txt;
                    break;
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            }
        }

        void BtnCloseClick(object sender, System.EventArgs e)
        {
            Hide();
        }
    }
}

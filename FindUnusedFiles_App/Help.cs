using System.Reflection;
using System.Windows.Forms;

namespace ITechnologyNET.FindUnusedFiles
{
    partial class Help : Form
    {
        public Help(string which = "manual")
        {
            InitializeComponent();

            switch (which)
            {
                case "changelog":
                    Text              = string.Format("Changelog: v{0}", AssemblyVersion);
                    richTextBox1.Text = Properties.Resources.changelog_txt;
                    break;

                case "license":
                    Text              = "License";
                    richTextBox1.Text = Properties.Resources.license_txt;
                    break;

                default:
                    Text              = "Manual";
                    richTextBox1.Text = Properties.Resources.manual_txt;
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

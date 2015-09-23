using System.Windows.Forms;

namespace ITechnologyNET.FindUnusedFiles
{
    /// <summary>
    /// http://stackoverflow.com/a/13446223/896849
    /// </summary>
    public static class GuiExtensionMethods
    {
        /// <summary>
        /// Enable/Disable this control and all it's children
        /// </summary>
        public static void EnabledControlAndChildren(this Control con, bool enable)
        {
            if (con != null)
            {
                foreach (Control c in con.Controls)
                {
                    EnabledControlAndChildren(c, enable);
                }
                con.Enabled = enable;
            }
        }

        /// <summary>
        /// Enable/Disable this control and it's immediate parents
        /// </summary>
        public static void EnableControlAndParents(this Control con, bool enable)
        {
            if (con != null)
            {
                con.Enabled = enable;
                EnableControlAndParents(con.Parent, enable);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project.helper_classes
{
    static class FixWindowSize
    {
        public static void FixLayout(Form form)
        {
            // Define the border style of the form to a dialog box.
            form.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            form.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            form.MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}

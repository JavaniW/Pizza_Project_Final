using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pizza_Project.database.Models.order_info;

namespace Pizza_Project.UserControls
{
    public partial class CartItemControl : UserControl
    {
        public CartItemControl(OrderItems orderItem)
        {
            InitializeComponent();
            this.label1.Text = orderItem.Name;
            this.numericUpDown1.Value = orderItem.Quantity;
        }

        private void CartItemControl_Load(object sender, EventArgs e)
        {

        }
    }
}

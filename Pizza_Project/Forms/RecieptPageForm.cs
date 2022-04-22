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

namespace Pizza_Project.Forms
{
    public partial class RecieptPageForm : Form
    {
        public RecieptPageForm(List<OrderItems> cartItems, double cartTotal)
        {
            InitializeComponent();
        }

        private void RecieptPageForm_Load(object sender, EventArgs e)
        {
        }
    }
}

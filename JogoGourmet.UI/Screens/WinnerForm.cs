using JogoGourmet.Core;
using JogoGourmet.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet.UI.Screens
{
    public partial class WinnerForm : Form
    {
        public WinnerForm()
        {
            InitializeComponent();
            lbWin.Text = GameWords.WinMessage;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

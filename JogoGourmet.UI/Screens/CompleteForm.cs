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
    public partial class CompleteForm : Form
    {
        private readonly CharacteristicDto _dto;

        public CompleteForm(CharacteristicDto dto, string newFood, string wrongFood)
        {
            InitializeComponent();
            lbAsk.Text = string.Format(GameWords.NewFoodIsButOldNo, newFood, wrongFood);
            _dto = dto;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _dto.Name = txtCharacteristic.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _dto.Name = "null";
            Close();
        }
    }
}

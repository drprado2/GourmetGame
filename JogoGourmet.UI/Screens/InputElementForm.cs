using JogoGourmet.Resources;
using System.Windows.Forms;

namespace JogoGourmet.UI.Screens
{
    public partial class InputElementForm : Form
    {
        private readonly FoodDto _dto;

        public InputElementForm(FoodDto dto)
        {
            InitializeComponent();
            lbAsk.Text = GameWords.WhatDishYouThink;
            _dto = dto;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _dto.Name = txtFood.Text;
            Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            _dto.Name = "null";
            Close();
        }
    }
}

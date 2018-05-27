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
    public partial class QuestionForm : Form
    {
        private readonly QuestionResultDto _dto;

        public QuestionForm(QuestionResultDto dto, string foodLabel)
        {
            InitializeComponent();
            _dto = dto;
            LbTitle.Text = string.Format(GameWords.DishYouImagine, foodLabel);
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            _dto.Result = true;
            Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            _dto.Result = false;
            Close();
        }
    }
}

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
    public partial class StartForm : Form
    {
        private readonly IGameManager _gameManager;

        public StartForm(IGameManager gameManager)
        {
            InitializeComponent();
            _gameManager = gameManager;
            LbTitle.Text = GameWords.ThinkDishLiked;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            _gameManager.StartGame();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrzalNaPlus
{
    public partial class MainMenu : Form
    {
        public static int Difficulty = 1;
        private static Dictionary<int, int> DiffToDefenderCount;

        public MainMenu()
        {
            InitializeComponent();
            DiffToDefenderCount = new Dictionary<int, int>();

            DiffToDefenderCount.Add(0, 2);
            DiffToDefenderCount.Add(1, 3);
            DiffToDefenderCount.Add(2, 5);

            DifficultyLabel.Text = "Difficulty: " + (Difficulty + 1);
        }

        public static int GetDeffendersCount()
        {
            return DiffToDefenderCount[Difficulty];
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var gameplay = new Gameplay();
            gameplay.FormClosing += delegate { this.Show(); };
            gameplay.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DifficultyButton_Click(object sender, EventArgs e)
        {
            Difficulty++;
            if (Difficulty > 2) Difficulty = 0;

            DifficultyLabel.Text = "Difficulty: " + (Difficulty + 1);
        }
    }
}

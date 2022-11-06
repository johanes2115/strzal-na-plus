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
    public partial class Gameplay : Form
    {
        private ValuesGenerator generator;
        private List<DefenderButton> buttons;
        private List<Defender> defenders;

        public Gameplay()
        {
            InitializeComponent();
            defenders = new List<Defender>();
            buttons = new List<DefenderButton>();
            generator = new ValuesGenerator(MainMenu.Difficulty);

            generator.GenerateValues();


            for (int i = 0; i < MainMenu.GetDeffendersCount(); i++)
            {
                var defender = new Defender(i);
                this.Controls.Add(defender);
                defenders.Add(defender);

                //TODO: calculate correct button positions
                var button = new DefenderButton(i * Width / MainMenu.GetDeffendersCount() + 100, Height / 2,
                    generator.GetOperation(i).GetAnswer());

                button.Text = generator.GetOperation(i).GetOperationAsText();
                button.Name = "DefenderButton" + i;

                this.Controls.Add(button);
                buttons.Add(button);
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
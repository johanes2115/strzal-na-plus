using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrzalNaPlus
{
    public class Defender : PictureBox
    {
        private int val;

        public Defender(int val)
        {
            this.val = val;
            BackColor = System.Drawing.Color.Beige;
            this.Click += new System.EventHandler(OnClick);
            //TODO: set height based on given val
        }

        public void OnClick(object sender, EventArgs e)
        {

        }

        public void SnapToButton(DefenderButton button)
        {
            this.Location = button.Location;
        }

    }
}

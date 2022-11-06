using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrzalNaPlus
{
    public class DefenderButton : Button
    {
        private int Answer; 


        public DefenderButton(int posX, int posY, int Answer)
        {
            this.Answer = Answer;
            Location = new System.Drawing.Point(posX, posY);
            this.Click += new System.EventHandler(OnClick);
        }

        public void OnClick(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class TeerlingView : UserControl //dit is eigenlijk de presenter, de view noemt TeerlingView.cs [Design]
    {
        TeerlingControl _controller;

        public TeerlingView(TeerlingControl controller) //constructor
        {
            _controller = controller;

            InitializeComponent();
        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {
            buttonWerp.Visible = _controller.__model.isVisible;
        }

        private void buttonWerp_Click(object sender, EventArgs e)
        {
            if (!_controller.__model.isLocked)
            {
                // waarde van teerling ophalen uit het model
                _controller.werpTeerling();

                labelWerp.Text = _controller.__model.AantalOgen.ToString();

                Console.Write("test2");
            }

            

            //onderstaande berekening mag hier niet staan, want dit is de view --> moet dus eigenlijk naar controller
            /*
            Random random = new Random();
            int nieuwGetal = random.Next(1, 7);
            teerlingLabel.Text = nieuwGetal.ToString();
            */
        }

        private void labelWerp_Click(object sender, EventArgs e)
        {
            
            _controller.ChangeLock();
            if (_controller.__model.isLocked)
            {
                labelWerp.BackColor = Color.IndianRed;
            }
            else
            {
                labelWerp.BackColor = Color.Transparent;
            }
        }

        public void updateLabel()
        {
            if (!_controller.__model.isLocked)
            {

                labelWerp.Text = _controller.__model.AantalOgen.ToString();
            }
        }

        public void changeColor(int teller)
        {
            if (teller == 0)
            {
                labelWerp.BackColor = Color.Transparent;
            }
            else
            {
                labelWerp.BackColor = Color.IndianRed;
            }

        }


    }
}

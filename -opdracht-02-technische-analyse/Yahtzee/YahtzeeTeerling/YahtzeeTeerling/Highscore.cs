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
    public partial class Highscore : UserControl

    {

        ControlHighscore _controller;

        public Highscore(ControlHighscore controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void Highscore_Load(object sender, EventArgs e)
        {

        }

        public void updateHighscore( int highscore)
        {

            labelHighscore.Text = "Current Highscore: " + highscore.ToString();

        }

  
  }
}

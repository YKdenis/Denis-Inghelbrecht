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
  public partial class YahtzeeView : UserControl
  {
    YahtzeeController _controller;

    
    public List<TeerlingControl> teerlingen = new List<TeerlingControl>();
    
    

    public YahtzeeView(YahtzeeController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void YahtzeeView_Load(object sender, EventArgs e)
    {
      for (int teerlingNummer = 0; teerlingNummer < _controller.__Ymodel.aantalTeerlingen; teerlingNummer++)
      {
        // Maak instanties van de teerlingen aan en voeg deze toe aan de lijst
        TeerlingControl nieuweTeerling = new TeerlingControl();

        //voeg controller toe aan teerlingen lijst
        teerlingen.Add(nieuweTeerling);

      }

      for (int teerlingNummer = 0; teerlingNummer < _controller.__Ymodel.aantalTeerlingen; teerlingNummer++)
      {
        // huidigeTeerling invullen met de waarde van de teerling
        TeerlingControl huidigeTeerling = teerlingen[teerlingNummer];

        // Haal de teerling view uit de teerling controller
        TeerlingView huidigeTeerlingView = huidigeTeerling.getView();

        // Bepaal de x positie van de teerling
        int xPos = huidigeTeerlingView.Width * teerlingNummer;

        // zet de locatie op basis van de x positie
        huidigeTeerlingView.Location = new Point(xPos, 0);

        Console.WriteLine(huidigeTeerlingView);
        Controls.Add(huidigeTeerlingView);
      }
      
    }



    private void button1_Click(object sender, EventArgs e)
    {

      _controller._Hcontroller.calculateHighscore();
      if (teerlingen[0].__model.aantalWorpen < _controller.__Ymodel.maxAantalWorpen)
      {
        _controller.werpTeerlingen();
        teerlingen[0].__model.aantalWorpen++;
      }
      else
      {



        for (int aantalTeerlingenTeller = 0; _controller.__Ymodel.aantalTeerlingen > aantalTeerlingenTeller; aantalTeerlingenTeller++)
        {

          teerlingen[aantalTeerlingenTeller].getView().changeColor(1);
          teerlingen[aantalTeerlingenTeller].__model.isLocked = true;

        }


      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      teerlingen[0].__model.aantalWorpen = 0;

      for (int aantalTeerlingenTeller = 0; _controller.__Ymodel.aantalTeerlingen > aantalTeerlingenTeller; aantalTeerlingenTeller++)
      {

        teerlingen[aantalTeerlingenTeller].getView().changeColor(0);
        teerlingen[aantalTeerlingenTeller].__model.isLocked = false;
        

      }
    }
  }
}

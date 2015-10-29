using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {
        //public int aantalTeerlingen = 5;
        //public List<TeerlingControl> teerlingen = new List<TeerlingControl>();
        //public int[] randomNumbers;
        //public int maxAantalWorpen = 3;

       // ControlHighscore _controllerHighscore = new ControlHighscore();

        public Yahtzee()
        {
            

            InitializeComponent();
        }



       private void Yahtzee_Load(object sender, EventArgs e)
        {

          YahtzeeController yahtzeeController = new YahtzeeController();

          YahtzeeView yahtzeeView = yahtzeeController.getYView();

          ControlHighscore highscoreController = new ControlHighscore( yahtzeeController );

          yahtzeeController._Hcontroller = highscoreController;

          Highscore highscoreView = highscoreController.__view;

          int xposHighscore = yahtzeeView.Width;
  
          highscoreView.Location = new Point(xposHighscore, 20);

          Controls.Add(highscoreView);

          Controls.Add(yahtzeeView);

        //    Console.WriteLine("test");

        //    for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
        //    {
        //        // Maak instanties van de teerlingen aan en voeg deze toe aan de lijst
        //        TeerlingControl nieuweTeerling = new TeerlingControl();

        //        //voeg controller toe aan teerlingen lijst
        //        teerlingen.Add(nieuweTeerling);

        //    }
            
        //    for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
        //    {
        //        // huidigeTeerling invullen met de waarde van de teerling
        //        TeerlingControl huidigeTeerling = teerlingen[teerlingNummer];

        //        // Haal de teerling view uit de teerling controller
        //        TeerlingView huidigeTeerlingView = huidigeTeerling.getView();

        //        // Bepaal de x positie van de teerling
        //        int xPos = huidigeTeerlingView.Width * teerlingNummer;

        //        // zet de locatie op basis van de x positie
        //        huidigeTeerlingView.Location = new Point(xPos, 0);

        //        Console.WriteLine(huidigeTeerlingView);
        //        Controls.Add(huidigeTeerlingView);
        //    }


        //    // Highscore highscoreView = _controllerHighscore.__view;

        //   //  Controls.Add(highscoreView);
        //}

        //// TeerlingControl nieuweTeerling = new TeerlingControl();
        //// Controls.Add(nieuweTeerling.getVieuw() );

        //public void werpTeerlingen()
        //{

        //    for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
        //    {

        //        teerlingen[teerlingNummer].werpTeerling();
        //        teerlingen[teerlingNummer].getView().updateLabel();
        //        // randomNumbers[teerlingNummer] = teerlingen[teerlingNummer].__model.AantalOgen;


        //    }

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
            

        //    if (teerlingen[0].__model.aantalWorpen < maxAantalWorpen)
        //    {
        //        werpTeerlingen();
        //        teerlingen[0].__model.aantalWorpen++;
        //    }
        //    else
        //    {

                

        //        for(int aantalTeerlingenTeller = 0; aantalTeerlingen > aantalTeerlingenTeller; aantalTeerlingenTeller++ )
        //        {

        //            teerlingen[aantalTeerlingenTeller].getView().changeColor(1);
        //            teerlingen[aantalTeerlingenTeller].__model.isLocked = true;

        //        }
                

        //    }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    teerlingen[0].__model.aantalWorpen = 0;

        //    for (int aantalTeerlingenTeller = 0; aantalTeerlingen > aantalTeerlingenTeller; aantalTeerlingenTeller++)
        //    {

        //        teerlingen[aantalTeerlingenTeller].getView().changeColor(0);
        //        teerlingen[aantalTeerlingenTeller].__model.isLocked = false;

        //    }
        //}
    }
}

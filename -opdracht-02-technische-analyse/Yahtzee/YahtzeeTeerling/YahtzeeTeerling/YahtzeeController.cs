using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
  public class YahtzeeController
  {
    private YahtzeeView _Yview;
    private YahtzeeModel _Ymodel;
    public ControlHighscore _Hcontroller { get; set; }

    public YahtzeeModel __Ymodel
    {   
        get
      {
        return _Ymodel;
      }  
    }

    public YahtzeeController()
    {

      _Yview = new YahtzeeView(this);
      _Ymodel = new YahtzeeModel();

      

    }

    public YahtzeeView getYView()
    {

      return _Yview;

    }


    public void werpTeerlingen()
    {

      for (int teerlingNummer = 0; teerlingNummer < __Ymodel.aantalTeerlingen; teerlingNummer++)
      {

        _Yview.teerlingen[teerlingNummer].werpTeerling();
        _Yview.teerlingen[teerlingNummer].getView().updateLabel();
        // _Ymodel.randomNumbers[teerlingNummer] = _Yview.teerlingen[teerlingNummer].__model.AantalOgen;
        

      }

      
    }


  }
}

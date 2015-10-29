using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
  public class ControlHighscore
  {

    private Highscore _view;

    private HighscoreModel _model;

    private YahtzeeController _yController;



    public Highscore __view
    {

      get
      {
        return _view;
      }

    }

    public HighscoreModel __model
    {
      get
      {
        return _model;
      }
    }

    public ControlHighscore(YahtzeeController yahtzeeController)
    {
      // _Ycontroller = new YahtzeeController();
      _view = new Highscore(this);
      _model = new HighscoreModel();

      _yController = yahtzeeController;

    }

    public void calculateHighscore()
    {
      int highscore = 0;

      if (_yController.__Ymodel.maxAantalWorpen <= _yController.getYView().teerlingen[0].__model.aantalWorpen)
      {
        for (int teerlingteller = 0; _yController.__Ymodel.aantalTeerlingen > teerlingteller; teerlingteller++)
        {

          highscore += _yController.getYView().teerlingen[teerlingteller].__model.AantalOgen;
          
        }
        __view.updateHighscore(highscore);
      }
    }

    //public void calculateHighscore()
    //{

    //  for (int teller = 0; teller < _Ycontroller.__Ymodel.maxAantalWorpen; teller++)
    //  {

    //    __model.currentHighscore += _Ycontroller.__Ymodel.randomNumbers[teller];


    //  }

    //}
  }
}

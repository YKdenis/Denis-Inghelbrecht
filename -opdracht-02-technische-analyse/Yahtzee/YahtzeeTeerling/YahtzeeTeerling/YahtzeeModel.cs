using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
  public class YahtzeeModel
  {
    int _maxAantalWorpen = 3;
    int _aantalTeerlingen = 5;

    public List<TeerlingModel> randomNumbers { get ; set; }

    public YahtzeeModel ()
    {

      randomNumbers = new List<TeerlingModel>();

    }

    public int aantalTeerlingen {

      get { return _aantalTeerlingen; }
      set { value = _aantalTeerlingen; }

      }

    public int maxAantalWorpen
    {

      get { return _maxAantalWorpen; }
      set { value = _maxAantalWorpen; }

    }

    

  }
}

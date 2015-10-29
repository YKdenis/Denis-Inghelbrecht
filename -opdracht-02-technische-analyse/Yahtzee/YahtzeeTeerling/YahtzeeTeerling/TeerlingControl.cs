using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingControl
    {
        private TeerlingView _view;

        private TeerlingModel _model;


        public TeerlingModel __model {
            get
            {
                return _model;
            }
                
            }

        public TeerlingControl() {

            _view = new TeerlingView( this );
            _model = new TeerlingModel();
        }

        public TeerlingView getView()
        {

            return _view;
        }

        public void werpTeerling()
        {   
            // maak instantie van een random getal
            Random random = new Random(Guid.NewGuid().GetHashCode());
            
            // maak getal tussen 1 en 6
            int teerlingGetal = random.Next(1, 7);

            // voeg het getal toe aan aantalOgen in TeerlingModel
            _model.AantalOgen = teerlingGetal;

        }

        public void ChangeLock()
        {

            _model.isLocked = !_model.isLocked;
        }

    }
}

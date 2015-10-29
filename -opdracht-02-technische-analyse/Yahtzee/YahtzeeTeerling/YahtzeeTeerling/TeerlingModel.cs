using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingModel
    {

        int _aantalOgen = 0;
        bool _isLocked = false;
        bool _isVisible = false;
        int _aantalWorpen;

        public bool isLocked
        {
            get
            {
                return _isLocked;
            }
            set
            {
                _isLocked = value;
            }
        }

        public int AantalOgen
        {
            get
            {
                return _aantalOgen;
            }
            set
            {
                if (!isLocked)
                {
                    _aantalOgen = value;
                }
            }
        }

        public bool isVisible
        {

            get
            {
                return _isVisible;
            }
            set
            {
                value = _isVisible;
            }
            
        }

        public int aantalWorpen
        {

            get
            {
                return _aantalWorpen;
            }
            set
            {
                _aantalWorpen = value;
            }

        }

    }
}

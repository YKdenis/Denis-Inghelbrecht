using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class HighscoreModel
    {

        int _maxHighscore = 0;
        int _currentHighscore = 0;

        public int maxHighscore
        {
            get
            {
                return _maxHighscore;
            }
            set
            {
                value = _maxHighscore;
            }
        }

        public int currentHighscore
        {
            get
            {
                return _currentHighscore;
            }
            set
            {
                value = _currentHighscore;
            }
        }

    }
}

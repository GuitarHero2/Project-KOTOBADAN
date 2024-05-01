using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotoba_Project
{
    // Just a list of the JLPT levels used in the dictionary. It is directly inherited in the all (except the one used in the quiz) the dictionary scripts.

    class JLPTClass
    {
        public List<string> jlptLevel = new List<string>()
        {
            "None", "N1", "N2", "N3", "N4", "N5"
        };

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watics.Models
{
    public class CharacterClass
    {
        public string name { get; set; }
        public int baseStrength { get; set; }
        public int baseIntelligence { get; set; }
        public int baseAgility { get; set; }

        public CharacterClass(string name, int baseStrength, int baseIntelligence, int baseAgility)
        {
            this.name = name;
            this.baseStrength = baseStrength;
            this.baseIntelligence = baseIntelligence;
            this.baseAgility = baseAgility;
        }
    }
}

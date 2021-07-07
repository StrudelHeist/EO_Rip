using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtrianOdysseyClone.Data.Items.Armor
{
    public interface IArmor : IItem
    {
        public int DefenseModifier { get; set; }
        public int MagicDefenseModifier { get; set; }

        // TODO: Who can wear/use Armor
    }
}

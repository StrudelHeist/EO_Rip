using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Config
{
    public class CharacterConfigSection
    {
        public static string SectionName = "CharacterConfig";

        public List<CharacterConfig> Characters { get; set; }
    }
}

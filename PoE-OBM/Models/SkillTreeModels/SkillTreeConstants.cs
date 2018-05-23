using System.Collections.Generic;

namespace PoE_OBM.Models.SkillTreeModels
{
    public class SkillTreeConstants
    {
        public int PSSCentreInnerRadius { get; set; }
        public IEnumerable<CharacterAttributes> CharacterAttributes { get; set; }
        public IEnumerable<Classes> CharacterClasses { get; set; }
    }
}
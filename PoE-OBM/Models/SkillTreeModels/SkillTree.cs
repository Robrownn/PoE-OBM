using System.Collections.Generic;

namespace PoE_OBM.Models.SkillTreeModels
{
    public class SkillTree
    {
        public string ImageRoot { get; set; }
        public IEnumerable<float> ImageZoomLevels { get; set; }
        public int MinX { get; set; }
        public int MaxX { get; set; }
        public int MinY { get; set; }
        public int MaxY { get; set; }
        public IEnumerable<object> Assets { get; set; }
        public IEnumerable<CharacterData> CharacterData { get; set; }
        public IEnumerable<SkillTreeConstants> Constants { get; set; }
    }
}
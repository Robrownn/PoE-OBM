using System.Collections.Generic;

namespace PoE_OBM.Models.SkillTreeModels
{
    public class SkillTreeNodes
    {
        public string AscendancyName { get; set; }
        public int DexterityAddition { get; set; }
        public string NodeName { get; set; }
        public int GroupId { get; set; }
        public int IntelligenceAddition { get; set; }
        public string Icon { get; set; }
        public bool? IsAscendancyStart { get; set; }
        public bool IsJewelSocket { get; set; }
        public bool IsMultipleChoice { get; set; }
        public bool IsMultipleChoiceOption { get; set; }
        public bool IsKeyStone { get; set; }
        public bool IsMastery { get; set; }
        public bool IsNoteable { get; set; }
        
        // Radii of orbit (0 to 4, orbitRadii = [0,82,162,335,493])
        public int OrbitRadii { get; set; }
        
        // Index on the orbit (skillsPerOrbit = [1, 6, 12, 12, 40])
        public int OrbitIndex { get; set; }

        public IEnumerable<int> Children { get; set; }
        public int? PassivePointsGranted { get; set; }
        public IEnumerable<string> ReminderText { get; set; }
        public int StrengthAddition { get; set; }
        public IEnumerable<string> StatDescriptions { get; set; }
        
        public IEnumerable<object> ClassStartingNode { get; set; }
    }
}
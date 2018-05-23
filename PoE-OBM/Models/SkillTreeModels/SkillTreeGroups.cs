using System.Collections.Generic;

namespace PoE_OBM.Models.SkillTreeModels
{
    public class SkillTreeGroups
    {
        public IEnumerable<Orbital> Orbitals { get; set; }
        public IEnumerable<int> Nodes { get; set; }
        public float XCoord { get; set; }
        public float YCoord { get; set; }   
    }
}
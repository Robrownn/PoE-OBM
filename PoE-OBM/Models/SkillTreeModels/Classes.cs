using Newtonsoft.Json;

namespace PoE_OBM.Models.SkillTreeModels
{
    public class Classes
    {
        [JsonProperty("StrDexIntClass")]
        public int Scion { get; set; }

        [JsonProperty("IntClass")]
        public int Witch { get; set; }

        [JsonProperty("StrClass")]
        public int Marauder { get; set; }

        [JsonProperty("DexClass")]
        public int Ranger { get; set; }

        [JsonProperty("StrIntClass")]
        public int Templar { get; set; }

        [JsonProperty("StrDexClass")]
        public int Duelist { get; set; }

        [JsonProperty("DexIntClass")]
        public int Shadow { get; set; }
    }
}
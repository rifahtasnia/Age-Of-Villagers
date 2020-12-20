using AgeOfVillagers.Arab_Bedouin;
using AgeOfVillagers.Bangladeshi_Farmers;
using AgeOfVillagers.Egyptian_Kings;
using AgeOfVillagers.Inuit_Hunters;

namespace AgeOfVillagers
{
    public class Factory_Nation
    {
        public INation GetNation(string NationName)
        {
            if (NationName == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationName == "Arab Bedouin")
            {
                return new ArabBedouin();
            }
            else if (NationName == "Egyptian Kings")
            {
                return new EgyptianKings();
            }
            else if (NationName == "Inuit Hunters")
            {
                return new InuitHunters();
            }
            else
            {
                return new NullNation();
            }
        }
    }
}

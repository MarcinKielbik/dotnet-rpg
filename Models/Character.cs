namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id {get; set; }
        public string Name {get; set; } = "Akibrus";

        public int Strength {get; set; } = 10;

        public int HitPoints {get; set;} = 50;

        public int Intelligence {get; set;} = 70;
        public RpgModel Class  {get; set;} = RpgModel.Knight;
    }
}
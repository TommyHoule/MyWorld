namespace MyWorld.Models{
    public abstract class AbstractLivingEntity : AbstractModel
    {
        public int Age { get; set; }
        public string Category { get; set; }
        public Race _race;
    }
}
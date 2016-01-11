namespace BuilderPattern
{
    public abstract class VanisheBuilder
    {

        public Vanishe Vanishe { get; set; }

        public abstract void BuilderFrame();

        public abstract void BuilderEngine();

        public abstract void BuilderWheels();

        public abstract void BuilderDoors();
    }
}

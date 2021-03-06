namespace Server.Items
{
    public class GiantPixieCostume : BaseCostume
    {
        [Constructable]
        public GiantPixieCostume()
        {
            Name = "a giant pixie halloween costume";
            CostumeBody = 176;
        }

        public GiantPixieCostume(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}
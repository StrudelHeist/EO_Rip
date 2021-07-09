namespace EtrianOdysseyClone.Data.Items.Armor
{
    public interface IArmor : IItem
    {
        public int DefenseModifier { get; }
        public int MagicDefenseModifier { get; }

        // TODO: Who can wear/use Armor
    }
}

namespace EtrianOdysseyClone.Data.Items.Armor
{
    public class ButtonUpShirt : IArmor
    {
        public string Name { get; private set; }

        public int DefenseModifier { get; private set; }
        public int MagicDefenseModifier { get; private set; }

        public ButtonUpShirt()
        {
            Name = nameof(ButtonUpShirt);

            DefenseModifier = 1;
            MagicDefenseModifier = 1;
        }
    }
}

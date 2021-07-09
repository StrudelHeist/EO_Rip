namespace EtrianOdysseyClone.Data.Items.Weapons
{
    public class Keyboard : IWeapon
    {
        public string Name { get; private set; }

        public int AttackModifier { get; private set; }
        public int MagicAttackModifier { get; private set; }

        public Keyboard()
        {
            Name = nameof(Keyboard);

            AttackModifier = 1;
            MagicAttackModifier = 1;
        }
    }
}

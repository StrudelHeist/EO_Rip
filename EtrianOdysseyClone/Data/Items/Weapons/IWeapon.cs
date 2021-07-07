namespace EtrianOdysseyClone.Data.Items.Weapons
{
    public interface IWeapon : IItem
    {
        public int AttackModifier { get; set; }
        public int MagicAttackModifier { get; set; }

        // TODO: Who can wear/use weapon
    }
}

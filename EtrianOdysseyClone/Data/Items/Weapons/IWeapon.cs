namespace EtrianOdysseyClone.Data.Items.Weapons
{
    public interface IWeapon : IItem
    {
        public int AttackModifier { get; }
        public int MagicAttackModifier { get; }

        // TODO: Who can wear/use weapon
    }
}

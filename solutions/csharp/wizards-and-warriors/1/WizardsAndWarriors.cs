abstract class Character(string characterType)
{
    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior() : Character("Warrior")
{
    public override int DamagePoints(Character target) =>
        target.Vulnerable() ? 10 : 6;
}

class Wizard() : Character("Wizard")
{
    private bool _isSpellPrepared;

    public override int DamagePoints(Character target) =>
        _isSpellPrepared ? 12 : 3;

    public void PrepareSpell() => _isSpellPrepared = true;

    public override bool Vulnerable() => !_isSpellPrepared;
}

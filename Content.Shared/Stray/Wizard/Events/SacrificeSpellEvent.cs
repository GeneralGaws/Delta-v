using Content.Shared.Actions;
using Content.Shared.Damage;

namespace Content.Shared.Magic.Events;

public sealed partial class SacrificeSpellEvent : EntityTargetActionEvent, ISpeakSpell
{
    [DataField("healAmount", required: true)]
    [ViewVariables(VVAccess.ReadWrite)]
    public DamageSpecifier HealAmount = default!;

    [DataField("damageAmount", required: true)]
    [ViewVariables(VVAccess.ReadWrite)]
    public DamageSpecifier DamageAmount = default!;

    [DataField("speech")]
    public string? Speech { get; private set; }

}

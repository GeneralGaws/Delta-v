using Content.Shared.Actions;
using Content.Shared.Damage;

namespace Content.Shared.Magic.Events;

public sealed partial class LightningStrikeSpellEvent : EntityTargetActionEvent, ISpeakSpell

{
    [DataField("speech")]
    public string? Speech { get; private set; }

    [DataField("damageAmount", required: true)]
    [ViewVariables(VVAccess.ReadWrite)]
    public DamageSpecifier DamageAmount = default!;

}

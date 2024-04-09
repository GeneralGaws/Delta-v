using Content.Shared.Actions;
using Content.Shared.Damage;

namespace Content.Shared.Magic.Events;

public sealed partial class HealSpellEvent : EntityTargetActionEvent
{
    [DataField("healAmount", required: true)]
    [ViewVariables(VVAccess.ReadWrite)]
    public DamageSpecifier HealAmount = default!;

}

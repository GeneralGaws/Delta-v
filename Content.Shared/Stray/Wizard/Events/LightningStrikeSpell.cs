using Content.Shared.Actions;

namespace Content.Shared.Magic.Events;

public sealed partial class LightningStrikeSpellEvent : EntityTargetActionEvent, ISpeakSpell

{
    [DataField("speech")]
    public string? Speech { get; private set; }

    [DataField("range")]
    public float Range = 8f;

}

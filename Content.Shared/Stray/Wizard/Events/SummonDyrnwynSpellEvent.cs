using Content.Shared.Actions;

namespace Content.Shared.Magic.Events;

public sealed partial class SummonDyrnwynSpellEvent : InstantActionEvent, ISpeakSpell

{
    [DataField("speech")]
    public string? Speech { get; private set; }
}

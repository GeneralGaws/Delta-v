using Content.Shared.Actions;

namespace Content.Shared.Magic.Events;

public sealed partial class ItemToSnakeSpellEvent : EntityTargetActionEvent, ISpeakSpell

{
    [DataField("speech")]
    public string? Speech { get; private set; }
}

using Content.Shared.Actions;
using Robust.Shared.Audio;

namespace Content.Shared.Magic.Events;

public sealed partial class AnimateDeadSpellEvent : EntityTargetActionEvent, ISpeakSpell
{
    [DataField("range")]
    public float Range = 4f;

    [DataField("knockSound")]
    public SoundSpecifier AnimateSound = new SoundPathSpecifier("/Audio/Magic/staff_healing.ogg");

    [DataField("knockVolume")]
    public float AnimateVolume = 5f;

    [DataField("speech")]
    public string? Speech { get; private set; }
}

using Content.Shared.Actions;
using Robust.Shared.Audio;

namespace Content.Shared.Magic.Events;

public sealed partial class EMPSpellEvent : InstantActionEvent, ISpeakSpell
{
    [DataField("range")]
    public float Range = 8f;

    [DataField("empSound")]
    public SoundSpecifier EmpSound = new SoundPathSpecifier("/Audio/Items/Defib/defib_zap.ogg");

    [DataField("empVolume")]
    public float EmpVolume = 5f;

    [DataField("speech")]
    public string? Speech { get; private set; }
}

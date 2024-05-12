using Content.Shared.Actions;
using Robust.Shared.Audio;

namespace Content.Shared.Magic.Events;

public sealed partial class HulkFormSpellEvent : InstantActionEvent, ISpeakSpell
{
    /// <summary>
    ///     Should this smite delete all parts/mechanisms gibbed except for the brain?
    /// </summary>

    [DataField("speech")]
    public string? Speech { get; private set; }

    public SoundSpecifier SmokeSound = new SoundPathSpecifier("/Audio/Effects/smoke.ogg");
    public SoundSpecifier HulkScream = new SoundPathSpecifier("/Audio/Stray/Wizard/Mobs/hulk_scream.ogg");

}

using Content.Server.StationEvents.Events;
using Content.Shared.Random;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.StationEvents.Components;

[RegisterComponent, Access(typeof(PirateRadioSpawnRule))]
public sealed partial class PirateRadioSpawnRuleComponent : Component
{
    [DataField("PirateRadioShuttlePath")]
    public string PirateRadioShuttlePath = "Maps/Shuttles/DeltaV/DV-pirateradio.yml";

    [DataField("additionalRule")]
    public EntityUid? AdditionalRule;

    [DataField("debrisCount")]
    public int DebrisCount;

    [DataField("distanceModifier")]
    public float DistanceModifier;

    [DataField("debrisDistanceModifier")]
    public float DebrisDistanceModifier;
}

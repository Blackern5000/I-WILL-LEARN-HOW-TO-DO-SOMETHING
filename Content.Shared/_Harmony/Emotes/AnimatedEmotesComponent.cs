// Original code by whateverusername0 from https://github.com/Goob-Station/Goob-Station/pull/828
// Rewritten by Jajsha to remove duplicate code.

using Content.Shared.Chat.Prototypes;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Emoting;

// use as a template
//[Serializable, NetSerializable, DataDefinition] public sealed partial class AnimationNameEmoteEvent : EntityEventArgs { }

[Serializable, NetSerializable, DataDefinition] public sealed partial class AnimatedEmoteEvent : EntityEventArgs
{
    // Name of the emote to play
    [DataField] public String Emote;

    //Length of the emote, in miliseconds
    [DataField] public int Length;
}

[RegisterComponent, NetworkedComponent] public sealed partial class AnimatedEmotesComponent : Component
{
    [DataField] public ProtoId<EmotePrototype>? Emote;
}

[Serializable, NetSerializable] public sealed partial class AnimatedEmotesComponentState : ComponentState
{
    public ProtoId<EmotePrototype>? Emote;

    public AnimatedEmotesComponentState(ProtoId<EmotePrototype>? emote)
    {
        Emote = emote;
    }
}

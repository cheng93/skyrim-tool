using System.ComponentModel;

namespace Rpg.Models.Common.Enums
{
    public enum Skill
    {
        Alchemy,
        Alteration,
        Archery,
        Barter,
        Block,
        Conjuration,
        Destruction,
        Enchanting,
        [Description("Heavy Armor")]
        HeavyArmor,
        Illusion,
        [Description("Light Armor")]
        LightArmor,
        Lockpicking,
        [Description("One-Handed")]
        OneHanded,
        Persuasion,
        Pickpocket,
        Restoration,
        Smithing,
        Sneak,
        [Description("Two-Handed")]
        TwoHanded
    }
}
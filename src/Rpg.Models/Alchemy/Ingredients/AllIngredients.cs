using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rpg.Models.Alchemy.Ingredients
{
    public static partial class AllIngredients
    {
        private static readonly List<IIngredient> privateList;

        static AllIngredients()
        {
            privateList = new List<IIngredient>()
            {
                AllIngredients.AbeceanLongfin,
                AllIngredients.BearClaws,
                AllIngredients.Bee,
                AllIngredients.BeehiveHusk,
                AllIngredients.BeritsAshes,
                AllIngredients.BleedingCrown,
                AllIngredients.Blisterwort,
                AllIngredients.BlueButterflyWing,
                AllIngredients.BlueDartwing,
                AllIngredients.BlueMountainFlower,
                AllIngredients.BoneMeal,
                AllIngredients.BriarHeart,
                AllIngredients.ButterflyWing,
                AllIngredients.CanisRoot,
                AllIngredients.CharredSkeeverHide,
                AllIngredients.ChaurusEggs,
                AllIngredients.ChickensEgg,
                AllIngredients.CreepCluster,
                AllIngredients.CrimsonNirnroot,
                AllIngredients.CyrodilicSpadetail,
                AllIngredients.DaedraHeart,
                AllIngredients.Deathbell,
                AllIngredients.DragonsTongue,
                AllIngredients.DwarvenOil,
                AllIngredients.Ectoplasm,
                AllIngredients.ElvesEar,
                AllIngredients.EyeOfSabreCat,
                AllIngredients.FalmerEar,
                AllIngredients.FireSalts,
                AllIngredients.FlyAmanita,
                AllIngredients.FrostMirriam,
                AllIngredients.FrostSalts,
                AllIngredients.Garlic,
                AllIngredients.GiantLichen,
                AllIngredients.GiantsToe,
                AllIngredients.GlowDust,
                AllIngredients.GlowingMushroom,
                AllIngredients.GrassPod,
                AllIngredients.HagravenClaw,
                AllIngredients.HagravenFeathers,
                AllIngredients.HangingMoss,
                AllIngredients.HawkBeak,
                AllIngredients.HawkFeathers,
                AllIngredients.Histcarp,
                AllIngredients.Honeycomb,
                AllIngredients.HumanFlesh,
                AllIngredients.HumanHeart,
                AllIngredients.IceWraithTeeth,
                AllIngredients.ImpStool,
                AllIngredients.JarrinRoot,
                AllIngredients.JazbayGrapes,
                AllIngredients.JuniperBerries,
                AllIngredients.LargeAntlers,
                AllIngredients.Lavender,
                AllIngredients.LunaMothWing,
                AllIngredients.MoonSugar,
                AllIngredients.MoraTapinella,
                AllIngredients.MudcrabChitin,
                AllIngredients.NamirasRot,
                AllIngredients.Nightshade,
                AllIngredients.Nirnroot,
                AllIngredients.NordicBarnacle,
                AllIngredients.OrangeDartwing,
                AllIngredients.Pearl,
                AllIngredients.PineThrushEgg,
                AllIngredients.PowderedMammothTusk,
                AllIngredients.PurpleMountainFlower,
                AllIngredients.RedMountainFlower,
                AllIngredients.RiverBetty,
                AllIngredients.RockWarblerEgg,
                AllIngredients.SabreCatTooth,
                AllIngredients.SaltPile,
                AllIngredients.ScalyPholiota,
                AllIngredients.SilversidePerch,
                AllIngredients.SkeeverTail,
                AllIngredients.SlaughterfishEgg,
                AllIngredients.SlaughterfishScales,
                AllIngredients.SmallAntlers,
                AllIngredients.SmallPearl,
                AllIngredients.Snowberries,
                AllIngredients.SpiderEgg,
                AllIngredients.SprigganSap,
                AllIngredients.SwampFungalPod,
                AllIngredients.Taproot,
                AllIngredients.ThistleBranch,
                AllIngredients.TorchbugThorax,
                AllIngredients.TrollFat,
                AllIngredients.TundraCotton,
                AllIngredients.VampireDust,
                AllIngredients.VoidSalts,
                AllIngredients.Wheat,
                AllIngredients.WhiteCap,
                AllIngredients.WispWrappings
            };

            List = new ReadOnlyCollection<IIngredient>(privateList);
        }

        public static readonly IEnumerable<IIngredient> List;
    }
}
using System.Collections.Generic;

namespace Werewolf_Node
{
    static class Settings
    {
#if DEBUG
        public static string ServerIP = "127.0.0.1";
#else
        public static string ServerIP = "127.0.0.1";

#endif
#if DEBUG
        public static int Port = 9049;
#elif RELEASE
        public static int Port = 9050;
#elif RELEASE2
        public static int Port = 9051;
#elif BETA
        public static int Port = 9052;
#endif


#if RELEASE2
        internal static List<string> VillagerDieImages = new List<string> { "BQADAwAD2QEAAnQXsQeU2FMN-2D3GgI", "BQADAwADggADdBexB1_X0udQaRs7Ag", "BQADBAADWAMAAt4cZAcXTtE-UCQXxAI" }; //1
        internal static List<string> WolfWin = new List<string> { "BQADAwADgQADdBexB5kx2CsSNDp2Ag", "BQADAwADgAADdBexBx7XahnW5XBsAg" };
        internal static List<string> WolvesWin = new List<string> { "BQADBAADlwMAAtgaZAeaog1gGP_fkwI", "BQADBAADcAMAAn8ZZAfjUfLaMGoxzgI" };
        internal static List<string> VillagersWin = new List<string> { "BQADAwADgwADdBexB90OD5PHXLAuAg" };
        internal static List<string> NoWinner = new List<string> { "BQADBAAD8QgAAqIeZAeLBjBE4l0LSAI", "BQADBAADuAMAAlUXZAfHXDmd504z5AI" };
        internal static List<string> StartGame = new List<string> { "BQADAwADhAADdBexB7b36d3MSPzDAg", "BQADBAADwg0AAu0XZAcwCVhaZgAB_CsC" };
        internal static List<string> StartChaosGame = new List<string> { "BQADAwAD1wEAAnQXsQeswdJwV9BIyQI", "BQADAwAD2AEAAnQXsQeGw_-A8E7DLwI" }; //2
        internal static List<string> TannerWin = new List<string> { "BQADBAADQwgAAuQaZAcjXuF_tkE3JwI", "BQADBAAD_gMAAtgaZAf2YeVX6mXnUQI" };
        internal static List<string> CultWins = new List<string> { "BQADBAADWAMAAosYZAcuRvZYBpQmXwI", "BQADBAADHwsAAgUYZAcUTEIahD8XSQI" };
        internal static List<string> SerialKillerWins = new List<string> { "BQADBAADdQMAAsEcZAd7skaRqoWKzQI", "BQADBAADmgMAArgcZAdPyqayfRT6bQI", "BQADBAADOAQAAqUXZAeeuV5vjRd6QAI", "BQADBAADKwMAAsQZZAfwd2_EAeeOTgI" };
        internal static List<string> LoversWin = new List<string> { "BQADBAAD8hUAAhYYZAeHmbRRzioXXQI", "BQADBAADYAMAAkMdZAfR4qo8c95FGgI" };
#else
        public static List<string> VillagerDieImages = new List<string> { "CgADBAADc2sAAqMeZAdCOJCA-3WqqwI", "CgADBAAD2WkAAtkZZAcFH2xk8VqfjgI", "CgADBAADxmoAAo4bZAeMyqeIJb5U2AI", "CgADBAADlWsAAgYdZAe12V70EI6cowI" };
        //public static List<string> WolfWin = new List<string> { "CgADBAAD0WsAAjgdZAeHgZGsasnpGQI", "CgADBAAD3moAAkUaZAd88vHN9plYowI" };
        //public static List<string> WolvesWin = new List<string> { "CgADBAAD2GsAAvgdZAejE-0eBt22BgI", "CgADBAAD3wMAAlsZZAd3Vsnpg3sxWQI", "CgADBAADImsAAjIbZAea9taGpilfIAI" };
        public static List<string> WolfWin = new List<string> { "CgACAgUAAxkBAAEMPBFiNs6NKWbcBirecm-0RXSuzJm2FwACsAQAApKWuFX8V2dsHwVJ_SME", "CgACAgQAAxkBAAEMPvNiNzxy9_S-PJwunA-nHyK2b2GqjAACEQMAAu2CvVJIhk1OP5KEyCME" };
        public static List<string> WolvesWin = new List<string> { "CgACAgUAAxkBAAEMPBNiNs6bDKLz8Zktk5E2s1uGejpQVAACsQQAApKWuFWVSS09U4k-RyME" };
        public static List<string> VillagersWin = new List<string> { "CgADBAADNGwAAvEcZAcGdLCMhOMG8gI" };
        public static List<string> NoWinner = new List<string> { "CgADBAADBwUAAn0aZAeUzqKubLZQhAI", "CgADBAAD_GoAAq0XZAdSVdbMZBIEgAI" };
        public static List<string> StartGame = new List<string> { "CgADBAADf6QAAtEYZAdLYoKqTq7H9gI", "CgADBAADvKUAAvocZAdyaDieWimZggI" };
        public static List<string> StartChaosGame = new List<string> { "CgADBAADK2wAAoUaZAcpyyUWqlZLmwI" };
        public static List<string> TannerWin = new List<string> { "CgADBAADXGsAAo0eZAem6VPuD-KozwI", "CgADBAAD0moAAhweZAcEfvzmrDzttwI" };
        public static List<string> CultWins = new List<string> { "CgADBAADTWsAAuYbZAdM5PyPwMWyTQI", "CgADBAADnQMAAocaZAfCDoLFcnO0yQI" };
        public static List<string> SerialKillerWins = new List<string> { "CgADBAADwwMAAjEXZAeHOO6ufLgjWwI", "CgADBAAD7WsAAtwaZAe-stCvjRMSDAI", "CgADBAAD2GoAAi4dZAcbua8rUBEHuAI", "CgADBAADt2sAAisaZAe63jaTlEq3VgI" };
        public static List<string> LoversWin = new List<string> { "CgADBAADlWoAAucXZAdkf-9rDgLLJgI", "CgADBAADt2oAApscZAc-T_QnOKHCGgI" };
        public static List<string> SKKilled = new List<string> { "CgACAgQAAxkBAAEMJbNiI1MS2b0Oj5lvEfrd9tW-mzKG2AACfvgAAtUaZAfkONMPSvrUZyME", "CgACAgQAAxkBAAEMJbViI1MVazTopT6Mnc5qyD4cwSt2JgACNZ8AAu0XZAfNnl9CA3IZESME" };
        internal static List<string> ArsonistWins = new List<string> { "CgACAgQAAxkBAAEMJbFiI1LQGxTNpHsLYTScOu-i_DmkdAACuwADTz49U6-hYK8yMHfIIwQ" };
        internal static List<string> BurnToDeath = new List<string> { "CgACAgQAAxkBAAEMJaliI1HWT_uysyxvFsBDxkGdMQbSvwACqwADa589U8mfAAEy3NtopSME" };
        internal static List<string> RefugeeWin = new List<string> { "CgACAgQAAxkBAAEMcrhijaxIcb0xthpFDl8pHTxFRNkDGwAC3AIAAho6RFNEvf5sUdXB3iQE" };
        internal static List<string> BlueberryWin = new List<string> { "CgADBAADVAADNWylUfrO0pi-43-SAg" };

#endif
        /* beta
        public static List<string> VillagerDieImages = new List<string> { "BQADAwADggADdBexBxVNNy-rt--bAg", "BQADBAADWAMAAt4cZAfbY0WobzNPwAI", "BQADBAADKgMAAoMbZAc7Ldme4T3DKQI" };
        public static List<string> WolfWin = new List<string> { "BQADAwADgQADdBexBzrFBt-CBlhbAg", "BQADAwADgAADdBexB88vVl1RuLb3Ag" };
        public static List<string> WolvesWin = new List<string> { "BQADBAADcAMAAn8ZZAfjilsAAeijzEAC", "BQADBAADlwMAAtgaZAcKX7eF4AgXCAI" };
        public static List<string> VillagersWin = new List<string> { "BQADAwADgwADdBexB5XubJT7w_zDAg" };
        public static List<string> NoWinner = new List<string> { "BQADBAAD8QgAAqIeZAdO5PeO55YsOQI", "BQADBAADuAMAAlUXZAePrr-YU3PDJwI" };
        public static List<string> StartGame = new List<string> { "BQADBAADwg0AAu0XZAdw1sAIIH6xQQI", "BQADAwADhAADdBexByVGjSOQUSx_Ag" };
        public static List<string> StartChaosGame = new List<string> { "BQADBAAD7wYAAgcYZAfk95HeMjOEfgI", "BQADBAAD_wcAAiUYZAcehPF7vHGFXAI" };
        public static List<string> TannerWin = new List<string> { "BQADBAAD_gMAAtgaZAeTCzBjKyXi6wI", "BQADBAADQwgAAuQaZAcBXBZ1bAUmwQI" };
        public static List<string> CultWins = new List<string> { "BQADBAADWAMAAosYZAfwfixffVnZywI", "BQADBAADHwsAAgUYZAfm4J7Dr5HpJQI" };
        public static List<string> SerialKillerWins = new List<string> { "BQADBAADdQMAAsEcZAf2I8Sj2kPcNQI", "BQADBAADmgMAArgcZAebNN10T84w9AI", "BQADBAADKwMAAsQZZAflRhJNO_knQAI", "BQADBAADOAQAAqUXZAcKgmVLwfIHvAI" };
        public static List<string> LoversWin = new List<string> { "BQADBAADYAMAAkMdZAf0_rs89KCyDAI", "BQADBAAD8hUAAhYYZAcV2T0l7f-lJQI" };
        public static List<string> SKKilled = new List<string> { "CgADBAADNZ8AAu0XZAd3o6VVV4IvLQI", "CgADBAADfvgAAtUaZAfmDpy1f5hnRwI" };
        public static List<string> ArsonistWins = new List<string> { "CgADBAADuwADTz49UzDYA8zEWtN0Ag" };
        public static List<string> BurnToDeath = new List<string> { "CgADBAADqwADa589U9Z936jXmRz4Ag" };
#endif
    */

        public static int
#if DEBUG
            MinPlayers = 1,

#else
            MinPlayers = 5,
#endif
            MaxPlayers = 35,
            TimeDay = 60,
            TimeNight = 90,
            TimeLynch = 90,
#if !DEBUG
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            HunterConversionChance = 50,
            HunterKillCultChance = 50,
            HunterKillWolfChanceBase = 30,
            SerialKillerConversionChance = 20,
            AlphaWolfConversionChance = 20,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            OracleConversionChance = 50,
            SandmanConversionChance = 60,
            WiseElderConversionChance = 30,
            PacifistConversionChance = 80,
            ThiefStealChance = 50,
            ChemistSuccessChance = 50,
            GraveDiggerConversionChance = 30,
            AugurConversionChance = 40,
            BulbConversionChance = 20,
#else
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            HunterConversionChance = 50,
            HunterKillCultChance = 50,
            HunterKillWolfChanceBase = 30,
            SerialKillerConversionChance = 20,
            AlphaWolfConversionChance = 20,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            OracleConversionChance = 50,
            SandmanConversionChance = 60,
            WiseElderConversionChance = 30,
            PacifistConversionChance = 80,
            ThiefStealChance = 100,
            ChemistSuccessChance = 50,
            GraveDiggerConversionChance = 30,
            AugurConversionChance = 40,
#endif

            GameJoinTime = 86400,
            MaxJoinTime = 300;


#if DEBUG
        //public static long MainChatId = -134703013;
        public static long MainChatId = -1001049529775; //Beta group
#else
        public static long MainChatId = -1001030085238;
#endif
        public static long VeteranChatId = -1001322721489;
        public static string VeteranChatLink = "werewolfvets";

        public static bool RandomLynch = false;
    }
}

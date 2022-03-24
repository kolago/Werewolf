﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werewolf_Control.Helpers
{
    internal static class Settings
    {

        //By the way, these admin ports will have IP whitelisting.  Don't even bother trying to connect to them :P
        //The regular ports are not even open on the firewall
#if DEBUG
        public static int Port = 9049;
        public static int AdminPort = 9059;
#elif RELEASE
        public static int Port = 9050;  //9050-@werewolfbot 
        public static int AdminPort = 9060;
#elif RELEASE2
        public static int Port = 9051;  //9051-@werewolfIIbot
        public static int AdminPort = 9063; //9061 not responding
#elif BETA
        public static int Port = 9052;
        public static int AdminPort = 9062;
#endif



        public static string TcpSecret => Environment.MachineName.GetHashCode().ToString();
        public static readonly long PersianSupportChatId = -1001398432551;
        public static readonly long MainChatId = -1001049529775; //Beta group
        public static readonly long SupportChatId = -1001060486754; //@werewolfsupport
        public static readonly long PrimaryChatId = -1001268085464; //@werewolfgame
        public static readonly string DevChannelId = "@greywolfdev"; //@greywolfdev
        public static readonly long VeteranChatId = -1001322721489;
        public static readonly string VeteranChatLink = "werewolfvets";
        public static readonly string VeteranChatUrl = $"https://t.me/{VeteranChatLink}";
        public static readonly long TranslationChatId = -1001074012132;
        public static readonly long AdminChatId = -1001094155678;
        public static readonly long ErrorGroup = -1001098399855;
        public static readonly long BetaReportingChatId = -1001235990177;

        public static readonly string GifStoragePath = @"C:/inetpub/gifs";

#if RELEASE2
        public static List<string> VillagerDieImages = new List<string> { "BQADAwAD2QEAAnQXsQeU2FMN-2D3GgI", "BQADAwADggADdBexB1_X0udQaRs7Ag", "BQADBAADWAMAAt4cZAcXTtE-UCQXxAI" }; //1
        public static List<string> WolfWin = new List<string> { "BQADAwADgQADdBexB5kx2CsSNDp2Ag", "BQADAwADgAADdBexBx7XahnW5XBsAg" };
        public static List<string> WolvesWin = new List<string> { "BQADBAADlwMAAtgaZAeaog1gGP_fkwI", "BQADBAADcAMAAn8ZZAfjUfLaMGoxzgI" };
        public static List<string> VillagersWin = new List<string> { "BQADAwADgwADdBexB90OD5PHXLAuAg" };
        public static List<string> NoWinner = new List<string> { "BQADBAAD8QgAAqIeZAeLBjBE4l0LSAI", "BQADBAADuAMAAlUXZAfHXDmd504z5AI" };
        public static List<string> StartGame = new List<string> { "BQADAwADhAADdBexB7b36d3MSPzDAg", "BQADBAADwg0AAu0XZAcwCVhaZgAB_CsC" };
        public static List<string> StartChaosGame = new List<string> { "BQADAwAD1wEAAnQXsQeswdJwV9BIyQI", "BQADAwAD2AEAAnQXsQeGw_-A8E7DLwI" }; //2
        public static List<string> TannerWin = new List<string> { "BQADBAADQwgAAuQaZAcjXuF_tkE3JwI", "BQADBAAD_gMAAtgaZAf2YeVX6mXnUQI" };
        public static List<string> CultWins = new List<string> { "BQADBAADWAMAAosYZAcuRvZYBpQmXwI", "BQADBAADHwsAAgUYZAcUTEIahD8XSQI" };
        public static List<string> SerialKillerWins = new List<string> { "BQADBAADdQMAAsEcZAd7skaRqoWKzQI", "BQADBAADmgMAArgcZAdPyqayfRT6bQI", "BQADBAADOAQAAqUXZAeeuV5vjRd6QAI", "BQADBAADKwMAAsQZZAfwd2_EAeeOTgI" };
        public static List<string> LoversWin = new List<string> { "BQADBAAD8hUAAhYYZAeHmbRRzioXXQI", "BQADBAADYAMAAkMdZAfR4qo8c95FGgI" };
#elif RELEASE
        public static List<string> VillagerDieImages = new List<string> { "CgADBAADc2sAAqMeZAdCOJCA-3WqqwI", "CgADBAAD2WkAAtkZZAcFH2xk8VqfjgI", "CgADBAADxmoAAo4bZAeMyqeIJb5U2AI", "CgADBAADlWsAAgYdZAe12V70EI6cowI" };
        //public static List<string> WolfWin = new List<string> { "CgADBAAD0WsAAjgdZAeHgZGsasnpGQI", "CgADBAAD3moAAkUaZAd88vHN9plYowI" };
        //public static List<string> WolvesWin = new List<string> { "CgADBAAD2GsAAvgdZAejE-0eBt22BgI", "CgADBAAD3wMAAlsZZAd3Vsnpg3sxWQI" , "CgADBAADImsAAjIbZAea9taGpilfIAI"};
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
        public static List<string> ArsonistWins = new List<string> { "CgACAgQAAxkBAAEMJbFiI1LQGxTNpHsLYTScOu-i_DmkdAACuwADTz49U6-hYK8yMHfIIwQ" };
        public static List<string> BurnToDeath = new List<string> { "CgACAgQAAxkBAAEMJaliI1HWT_uysyxvFsBDxkGdMQbSvwACqwADa589U8mfAAEy3NtopSME" };
#else
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

        /// <summary>
        /// How many games are allowed for any given node
        /// </summary>
        public static int MaxGamesPerNode = 60;

        /// <summary>
        /// How many games on each node before starting a new node (to be added later)
        /// </summary>
#if DEBUG
        public static int NewNodeThreshhold = 10;
#else
        public static int NewNodeThreshhold = 30;
#endif
        public static int ShutDownNodesAt = 15;

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
#if DEBUG
            PlayerCountSeerCursed = 6,
            PlayerCountHarlot = 7,
            PlayerCountBeholderChance = 8,
            PlayerCountSecondWolf = 9,
            PlayerCountGunner = 9,
            PlayerCountTraitor = 10,
            PlayerCountGuardianAngel = 11,
            PlayerCountDetective = 12,
            PlayerCountApprenticeSeer = 13,
            PlayerCountCultist = 15,
            PlayerCountThirdWolf = 16,
            PlayerCountWildChild = 17,
            PlayerCountFoolChance = 18,
            PlayerCountMasons = 21,
            PlayerCountSecondCultist = 22,
            MaxGames = 80,
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            ChemistSuccessChance = 50,

#else
            PlayerCountSeerCursed = 6,
            PlayerCountHarlot = 7,
            PlayerCountBeholderChance = 8,
            PlayerCountSecondWolf = 9,
            PlayerCountGunner = 9,
            PlayerCountTraitor = 10,
            PlayerCountGuardianAngel = 11,
            PlayerCountDetective = 12,
            PlayerCountApprenticeSeer = 13,
            PlayerCountCultist = 15,
            PlayerCountThirdWolf = 16,
            PlayerCountWildChild = 17,
            PlayerCountFoolChance = 18,
            PlayerCountMasons = 21,
            PlayerCountSecondCultist = 22,
            MaxGames = 80,
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            ChemistSuccessChance = 50,
#endif

            GameJoinTime = 180,
            MaxExtend = 60;
    }
}

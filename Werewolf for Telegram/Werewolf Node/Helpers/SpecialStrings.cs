using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werewolf_Node.Helpers
{
    public static class SpecialStrings
    {
        public static Dictionary<string, string> Strings = new Dictionary<string, string>
        {
            { "Detonation", "{0} 抱着炸药包骑着哈罗单车冲向了 {1}  。一声轰鸣，城市里所有人都看见了一具烧焦的尸体...闻起来像烧过头的叉烧肉。{2}" },
            { "DetonatedWiseElder", "然而市民们细看之下，发现了长者残存的黑框眼镜一角。”这个傻X！“，市民们很气愤的没收了他的相关作案工具，他成为了普通市民，无法再搞爆破。" },
            { "AskDetonate", "你想爆破谁？" },
            { "AboutSpumpkin", "The Spumpkin 🎃 is a pumpkin grower known for his plump pumpkins, which can grow large enough to explode! When detonated, the Spumpkin and another player of their choice die from the impact. The Spumpkin wins with the rest of the villagers." },
            { "RoleInfoSpumpkin", "你是骑士堂吉诃德。由于你过于迷恋骑士而患上了疯病，会把其他看做\"风车\"。你能揣着炸药包以一定概率杀死\"风车\"。" },
            { "Spumpkin", "骑士堂吉诃德" },
            { "SpumpkinFailDetonate", "很遗憾，在过程中炸药包引线被汗水沾湿了，无法引爆。" },
            { "BlackDeathWinner", "Congratulations, {0}, YOU survived the {1} alone! Happy April Fool's!" },
            { "BlackDeathKilledAll", "Everybody in the village was killed by the {0} and only corpses are lying around! Happy April Fool's!" },
            { "BlackDeathLovers", "Congratulations, {0} and {1}, you are so madly in love that you even managed to survive the {2} together! Happy April Fool's!" },
        };
    }
}

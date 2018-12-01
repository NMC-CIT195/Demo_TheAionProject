using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject.Assets
{
    public static class GameText
    {
        public static string MissionIntro()
        {
            StringBuilder sb = new StringBuilder();
            sb.Clear();

            sb.Append("You have been hired by the Norlon Corporation to participate ");
            sb.Append("in its latest endeavor, the Aion Project. Your mission is to ");
            sb.Append("test the limits of the new Aion Engine and report back to ");
            sb.Append("the Norlon Corporation.");
            sb.Append(Environment.NewLine);
            sb.Append("Your first task will be to set up the initial parameters of your mission.");
            sb.Append("You have been hired by the Norlon Corporation to participate ");
            sb.Append("in its latest endeavor, the Aion Project. Your mission is to ");
            sb.Append("test the limits of the new Aion Engine and report back to ");
            sb.Append("the Norlon Corporation.");
            sb.Append(Environment.NewLine);
            sb.Append("Your first task will be to set up the initial parameters of your mission.");
            sb.Append(Environment.NewLine);
            sb.Append("Your first task will be to set up the initial parameters of your mission.");
            sb.Append("You have been hired by the Norlon Corporation to participate ");
            sb.Append("in its latest endeavor, the Aion Project. Your mission is to ");
            sb.Append("test the limits of the new Aion Engine and report back to ");
            sb.Append("the Norlon Corporation.");
            sb.Append(Environment.NewLine);
            sb.Append("Your first task will be to set up the initial parameters of your mission.");

            return sb.ToString();
        }
    }
}

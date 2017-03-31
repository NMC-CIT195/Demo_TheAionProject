using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject.Models
{
    public class Civilian : Npc, ISpeak
    {
        public List<string> Messages { get; set; }

        public string Speak()
        {
            if (this.Messages != null)
            {
                return GetMessage();
            }
            else
            {
                return $"My name is {base.Name} and I am a {base.Race}";
            }
        }

        private string GetMessage()
        {
            Random r = new Random();
            int messageIndex = r.Next(0, Messages.Count());
            return Messages[messageIndex];
        }
    }
}

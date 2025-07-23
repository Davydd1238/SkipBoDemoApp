using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipBoDemoLibrary
{
    public class PlayerModel
    {
        public string PlayerTitle { get; set; }
        public List<string> StockPile { get; set; } = new List<string>();
        public List<string> PlayingCards { get; set; } = new List<string>();
        public List<string> DiscardPileOne { get; set; } = new List<string>();
        public List<string> DiscardPileTwo { get; set; } = new List<string>();
        public List<string> DiscardPileThree { get; set; } = new List<string>();
        public List<string> DiscardPileFour { get; set; } = new List<string>();
    }
}

using System.Collections.Generic;
using Hokemon_Challenge.Pokemon.Impl;

namespace Hokemon_Challenge.Pokemon {

    public class LegendPokemon : AbstractPokemon {

        private EPokemonRarity rarity;
        
        public LegendPokemon(string name, EPokemonTypes type, int cp, Dictionary<PokeStats, int> stats) :
            base(name, type, cp, stats) {
            rarity = EPokemonRarity.Legend;
        }

        public void SetRarity(EPokemonRarity rarity) {
            this.rarity = rarity;
        }

        public EPokemonRarity GetRarity() {
            return rarity;
        }

    }
    
}
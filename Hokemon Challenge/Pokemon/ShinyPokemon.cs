using System.Collections.Generic;
using Hokemon_Challenge.Pokemon.Impl;

namespace Hokemon_Challenge.Pokemon {
    
    public class ShinyPokemon : AbstractPokemon {

        private EPokemonRarity rarity;
        
        public ShinyPokemon(string name, EPokemonTypes type, int cp, Dictionary<PokeStats, int> stats) :
            base(name, type, cp, stats) {
            rarity = EPokemonRarity.Shiny;
        }

        public void SetRarity(EPokemonRarity rarity) {
            this.rarity = rarity;
        }

        public EPokemonRarity GetRarity() {
            return rarity;
        }

    }
}
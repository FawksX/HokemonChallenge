using System;
using System.Collections.Generic;
using Hokemon_Challenge.Pokemon.Impl;

namespace Hokemon_Challenge.Pokemon {
    
    public class Pokemon : AbstractPokemon {

        private EPokemonRarity rarity;
        
        public Pokemon(string name, EPokemonTypes type, int cp, Dictionary<PokeStats, int> stats, EPokemonRarity rarity) :
            base(name, type, cp, stats, rarity) {
        }
        
        public static Builder builder = new Builder();

        
        public class Builder {
            private String name;
            private EPokemonTypes type;
            private int cp;
            private Dictionary<PokeStats, int> stats;
            private EPokemonRarity rarity;

            public Builder() {}

            public Builder Name(string name) {
                this.name = name;
                return this;
            }
            
            public Builder Type(EPokemonTypes type) {
                this.type = type;
                return this;
            }
            
            public Builder CP(int cp) {
                this.cp = cp;
                return this;
            }
            
            public Builder PokeStats(Dictionary<PokeStats, int> stats) {
                this.stats = stats;
                return this;
            }
            
            public Builder Rarity(EPokemonRarity rarity) {
                this.rarity = rarity;
                return this;
            }

            public Pokemon Build() {
                return new Pokemon(
                    name, type, cp, stats, rarity);
            }

        }
    }
    
    
}
using System;
using System.Collections.Generic;
using HokemonChallenge.Pokemon.Impl;

namespace HokemonChallenge.Pokemon {
    
    public class Pokemon : AbstractPokemon {

        public Pokemon(string name, EPokemonTypes type, int cp, Dictionary<PokeStats, int> ev, Dictionary<PokeStats, int> iv, EPokemonRarity rarity, EPokemonTeams team) :
            base(name, type, cp, ev, iv, rarity, team) {
        }

        public static PokeBuilder Builder() {
            return new PokeBuilder();
        }

        
        public class PokeBuilder {
            private String name;
            private EPokemonTypes type;
            private int cp;
            private Dictionary<PokeStats, int> ev;
            private Dictionary<PokeStats, int> iv;
            private EPokemonRarity rarity;
            private EPokemonTeams team;

            public PokeBuilder Name(string name) {
                this.name = name;
                return this;
            }
            
            public PokeBuilder Type(EPokemonTypes type) {
                this.type = type;
                return this;
            }
            
            public PokeBuilder CP(int cp) {
                this.cp = cp;
                return this;
            }
            
            public PokeBuilder EV(Dictionary<PokeStats, int> ev) {
                this.ev = ev;
                return this;
            }
            
            public PokeBuilder IV(Dictionary<PokeStats, int> iv) {
                this.iv = iv;
                return this;
            }
            
            public PokeBuilder Rarity(EPokemonRarity rarity) {
                this.rarity = rarity;
                return this;
            }

            public PokeBuilder Team(EPokemonTeams team) {
                this.team = team;
                return this;
            }

            public Pokemon Build() {
                return new Pokemon(
                    name, type, cp, ev, iv, rarity, team);
            }

        }
    }
    
}
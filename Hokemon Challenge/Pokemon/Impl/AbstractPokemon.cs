using System.Collections.Generic;

namespace Hokemon_Challenge.Pokemon.Impl {


    public abstract class AbstractPokemon : IPokemon {

        private string name;
        private EPokemonTypes type;
        private Dictionary<PokeStats, int> ev;
        private Dictionary<PokeStats, int> iv;
        private int cp;
        private EPokemonRarity rarity;

        public AbstractPokemon(string name, EPokemonTypes type, int cp, Dictionary<PokeStats, int> ev, Dictionary<PokeStats, int> iv, EPokemonRarity rarity) {
            this.name = name;
            this.type = type;
            this.cp = cp;
            this.ev = ev;
            this.iv = iv;
            this.rarity = rarity;
        }

        public void SetType(EPokemonTypes type) {
            this.type = type;
        }

        public void SetIV(PokeStats stat, int amount) {
            iv[stat] = amount;
        }
        
        public void SetEV(PokeStats stat, int amount) {
            ev[stat] = amount;
        }

        public void SetName(string name) {
            this.name = name;
        }

        public void SetCP(int cp) {
            this.cp = cp;
        }

        public string GetName() {
            return name;
        }

        public int GetCP() {
            return cp;
        }

        public EPokemonTypes GetType() {
            return type;
        }

        public int GetIV(PokeStats stat) {
            return iv[stat];
        }
        
        public int GetEV(PokeStats stat) {
            return ev[stat];
        }
        
        public void SetRarity(EPokemonRarity rarity) {
            this.rarity = rarity;
        }

        public EPokemonRarity GetRarity() {
            return rarity;
        }
        
    }
}
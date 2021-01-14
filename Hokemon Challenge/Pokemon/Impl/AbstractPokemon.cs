using System.Collections.Generic;

namespace Hokemon_Challenge.Pokemon.Impl {


    public abstract class AbstractPokemon : IPokemon {

        private string name;
        private EPokemonTypes type;
        private Dictionary<PokeStats, int> stats;
        private int cp;
        private EPokemonRarity rarity;

        public AbstractPokemon(string name, EPokemonTypes type, int cp, Dictionary<PokeStats, int> stats, EPokemonRarity rarity) {
            this.name = name;
            this.type = type;
            this.cp = cp;
            this.stats = stats;
            this.rarity = rarity;
        }

        public void setType(EPokemonTypes type) {
            this.type = type;
        }

        public void setStat(PokeStats stat, int amount) {
            stats[stat] = amount;
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

        public int GetStatAmount(PokeStats stat) {
            return stats[stat];
        }
        
        public void SetRarity(EPokemonRarity rarity) {
            this.rarity = rarity;
        }

        public EPokemonRarity GetRarity() {
            return rarity;
        }
        
    }
}
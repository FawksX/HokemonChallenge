using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace HokemonChallenge.Cache {
    public class PokeCache {

        private static Dictionary<string, Pokemon.Pokemon> _POKEMON = new Dictionary<string, Pokemon.Pokemon>();

        public static void Add(string name, Pokemon.Pokemon pokemon) {
            _POKEMON.Add(name, pokemon);
        }

        public static void Remove(string name, Pokemon.Pokemon pokemon) {
            _POKEMON.Remove(name);
        }

        public static bool Contains(string name) {
            return _POKEMON.ContainsKey(name);
        }

        public static Dictionary<string, Pokemon.Pokemon> getAll() {
            return _POKEMON;
        }

        public static Pokemon.Pokemon get(string name) {
            return _POKEMON[name];
        }
        

    }
}
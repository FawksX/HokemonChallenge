using HokemonChallenge.Cache;
using HokemonChallenge.Util;

namespace HokemonChallenge.ProgramStates {
    /**
     * Creates a Pokemon and adds it to the Cache
     */
    public class PokeBuilder {
        
        public static void open() {
            Pokemon.Pokemon newPoke = PokeUtil.CreatePokemon();

            MessageUtil.Msg("Pokemon Created!");
            PokeUtil.DisplayPoke(newPoke);

            if (PokeCache.Contains(newPoke.GetName())) {
                MessageUtil.Msg("ERROR! Pokemon already exists!");
            }

            PokeCache.Add(newPoke.GetName(), newPoke);
            
        }
    }
}
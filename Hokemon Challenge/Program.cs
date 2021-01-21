using HokemonChallenge.Cache;
using HokemonChallenge.Util;

namespace HokemonChallenge {
    class Program {
        public static void Main(string[] args) {

            while (true) {
                string keepMaking = MessageUtil.getInput("Do you want to continue making pokemon? (yes/no): ").ToString();
                if (keepMaking.ToLower().Equals("yes")) {
                    Pokemon.Pokemon newPoke = PokeUtil.CreatePokemon();

                    MessageUtil.Msg("Pokemon Created!");
                    PokeUtil.DisplayPoke(newPoke);

                    if (PokeCache.Contains(newPoke.GetName())) {
                        MessageUtil.Msg("ERROR! Pokemon already exists!");
                    }
                    
                    PokeCache.Add(newPoke.GetName(), newPoke);

                    if (keepMaking.ToLower().Equals("no")) {
                        MessageUtil.Msg("No more pokemon will be made!");
                        return;
                    }
                }
            }
        }
    }
}
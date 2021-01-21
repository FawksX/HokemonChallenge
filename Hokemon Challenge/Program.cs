using System.Collections.Generic;
using HokemonChallenge.Util;

namespace HokemonChallenge {
    
    class Program {
        
        public static void Main(string[] args) {
            
            Dictionary<string, Pokemon.Pokemon> definedPokemon = new Dictionary<string, Pokemon.Pokemon>();

            while (true) {
                string keepMaking = MessageUtil.getInput("Do you want to continue making pokemon? (yes/no): ").ToString();
                if (keepMaking.ToLower().Equals("yes")) {
                    Pokemon.Pokemon newPoke = PokeUtil.CreatePokemon();

                    MessageUtil.Msg("Pokemon Created!");
                    PokeUtil.DisplayPoke(newPoke);
                }
                if (keepMaking.ToLower().Equals("no")) {
                    MessageUtil.Msg("No more pokemon will be made!");
                    return;
                }
            }

        }
        
        
    }
}
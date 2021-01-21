
using System;
using HokemonChallenge.Cache;
using HokemonChallenge.Util;

namespace HokemonChallenge {
    class Program {
        public static void Main(string[] args) {

            while (true) {
                
                MessageUtil.MsgSpacer();
                MessageUtil.Msg("MAIN MENU");
                MessageUtil.MsgSpacer();
                MessageUtil.Msg("Type create to create a Pokemon");
                MessageUtil.Msg("Type battle to battle two pokemon");
                MessageUtil.Msg("Type exit to exit the program");
                MessageUtil.Msg("");
                string answer = (string) MessageUtil.getInput("Select: ");

                if (answer.ToLower().Equals("pokemon")) {
                    PokeBuilder.open();
                }

                if (answer.ToLower().Equals("battle")) {
                    if (PokeCache.get().Count < 2) {
                        MessageUtil.Msg("ERROR : You need atleast two pokemon in order to battle!");
                        continue;
                    }
                    PokeBattle.open();
                }

                if (answer.ToLower().Equals("exit")) {
                    MessageUtil.Msg("Exiting Program!");
                    return;
                }

            }
            
        }
    }
}
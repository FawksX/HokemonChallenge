using System.Collections.Generic;
using HokemonChallenge.Cache;
using HokemonChallenge.Config;
using HokemonChallenge.Pokemon.Impl;
using HokemonChallenge.ProgramStates;
using HokemonChallenge.Util;

namespace HokemonChallenge {
    class Program {
        public static void Main(string[] args) {

            while (true) {
                
                MessageUtil.MsgSpacer();
                MessageUtil.Msg("MAIN MENU");
                MessageUtil.MsgSpacer();
                MessageUtil.Msg(Messages.main_menu);
                string answer = (string) MessageUtil.getInput("Select: ");

                if (answer.ToLower().Equals("create")) {
                    PokeBuilder.open();
                }

                if (answer.ToLower().Equals("battle")) {
                    if (PokeCache.getAll().Count < 2) {
                        MessageUtil.Msg(Messages.battle_start_error);
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
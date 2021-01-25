
using System.Collections.Generic;
using HokemonChallenge.Cache;
using HokemonChallenge.Config;
using HokemonChallenge.Pokemon.Impl;
using HokemonChallenge.ProgramStates;
using HokemonChallenge.Util;

namespace HokemonChallenge {
    class Program {
        public static void Main(string[] args) {
            
            Dictionary<PokeStats, int> pokeStatsDefault = new Dictionary<PokeStats, int>();
            pokeStatsDefault.Add(PokeStats.Attack, 50);
            pokeStatsDefault.Add(PokeStats.Defense, 50);
            pokeStatsDefault.Add(PokeStats.Hp, 50);
            pokeStatsDefault.Add(PokeStats.Speed, 50);
            pokeStatsDefault.Add(PokeStats.SpecialAttack, 50);
            pokeStatsDefault.Add(PokeStats.SpecialDefense, 50);

            PokeCache.Add("poke1", Pokemon.Pokemon.Builder().Name("poke1")
                .Rarity(EPokemonRarity.Normal)
                .Team(EPokemonTeams.Instinct)
                .Type(EPokemonTypes.Bug)
                .CP(100)
                .EV(pokeStatsDefault).IV(pokeStatsDefault).Build());
            
            PokeCache.Add("poke2", Pokemon.Pokemon.Builder().Name("poke2")
                .Rarity(EPokemonRarity.Normal)
                .Team(EPokemonTeams.Valor)
                .Type(EPokemonTypes.Bug)
                .CP(100)
                .EV(pokeStatsDefault).IV(pokeStatsDefault).Build());

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
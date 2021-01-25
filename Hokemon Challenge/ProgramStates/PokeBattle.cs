using System;
using HokemonChallenge.Cache;
using HokemonChallenge.Pokemon.Impl;
using HokemonChallenge.Util;

namespace HokemonChallenge.ProgramStates {
    public class PokeBattle {
        public static void open() {
            Pokemon.Pokemon attacker = null;
            Pokemon.Pokemon defender = null;

            while (attacker == null || defender == null) {
                if (attacker == null) {
                    showPokes();
                    attacker = PokeCache.get((string) MessageUtil.getInput("Choose an attacker: "));
                }

                if (defender == null) {
                    showPokes(attacker.GetTeam());
                    defender = PokeCache.get((string) MessageUtil.getInput("Choose a defender: "));
                }
            }

            initiateBattle(attacker, defender);
        }

        private static void initiateBattle(Pokemon.Pokemon primaryAttacker, Pokemon.Pokemon primaryDefender) {
            int roundNumber = 0;


            while (primaryAttacker.GetHealth() > 0 && primaryDefender.GetHealth() > 0) {
                roundNumber++;
                
                MessageUtil.MsgSpacer();
                MessageUtil.Msg("ROUND " + roundNumber);

                Pokemon.Pokemon attacker;
                Pokemon.Pokemon defender;

                if (roundNumber % 2 == 0) {
                    defender = primaryAttacker;
                    attacker = primaryDefender;
                }
                else {
                    attacker = primaryDefender;
                    defender = primaryAttacker;
                }

                int thisAttack = PokeUtil.calculateValue(attacker, PokeStats.Attack);
                int thisDefense = PokeUtil.calculateValue(defender, PokeStats.Defense) / 2;

                MessageUtil.MsgSpacer();
                MessageUtil.TypewriterMsg(attacker.GetName() + " has dealt " + thisAttack + " to the Defender!");
                MessageUtil.TypewriterMsg("Defender has shielded " + thisDefense + ". New Health: " +
                                          ((defender.GetHealth() + thisDefense) - thisAttack));
                defender.SetHealth((defender.GetHealth() + thisDefense) - thisAttack);
            }

            if (primaryAttacker.GetHealth() > primaryDefender.GetHealth()) {
                MessageUtil.Msg(primaryAttacker.GetName() + " has won this battle!");
            }
            else {
                MessageUtil.Msg(primaryDefender.GetName() + "has won this battle!");
            }
        }

        private static void showPokes(EPokemonTeams teamNotToDisplay) {
            MessageUtil.MsgSpacer();
            MessageUtil.Msg("SHOWING ALL AVAILABLE POKES");
            foreach (Pokemon.Pokemon poke in PokeCache.getAll().Values) {
                if (poke.GetTeam() != teamNotToDisplay) {
                    MessageUtil.Msg(poke.GetName());
                }
            }
        }

        private static void showPokes() {
            MessageUtil.MsgSpacer();
            MessageUtil.Msg("SHOWING ALL POKES");
            foreach (Pokemon.Pokemon poke in PokeCache.getAll().Values) {
                MessageUtil.Msg(poke.GetName());
            }
        }
    }
}
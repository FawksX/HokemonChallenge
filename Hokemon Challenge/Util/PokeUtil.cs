using System;
using System.Collections.Generic;
using System.ComponentModel;
using HokemonChallenge.Pokemon.Impl;

namespace HokemonChallenge.Util {
    public class PokeUtil {
        
        public static Pokemon.Pokemon CreatePokemon() {
            MessageUtil.Msg("HOKEMON CREATION");
            MessageUtil.MsgSpacer();
            
            string name = (string) MessageUtil.getInput("Name of Pokemon: ");
            
            string tempRar = (string) MessageUtil.getInput("Rarity (normal/shiny/legend): ");
            EPokemonRarity rarity = EnumUtil.GetEnumValue<EPokemonRarity>(tempRar);

            if (rarity == default) {
                throw new InvalidEnumArgumentException();
            }

            string tempType = (string) MessageUtil.getInput("Type: ");
            EPokemonTypes type = EnumUtil.GetEnumValue<EPokemonTypes>(tempType);
            
            if (type == default) {
                throw new InvalidEnumArgumentException();
            }
            
            int cp = MessageUtil.getInt("CP of pokemon: ");
            
            MessageUtil.MsgSpacer();
            MessageUtil.Msg("IVs");
            MessageUtil.MsgSpacer();
            Dictionary<PokeStats, int> iv = GenerateStats();
            MessageUtil.MsgSpacer();
            MessageUtil.Msg("EVs");
            MessageUtil.MsgSpacer();
            Dictionary<PokeStats, int> ev = GenerateStats();
            
            string tempTeam = (string) MessageUtil.getInput("Team (instinct/valor/mystic): ");
            EPokemonTeams team = EnumUtil.GetEnumValue<EPokemonTeams>(tempTeam);

            Pokemon.Pokemon pokemon = Pokemon.Pokemon.Builder()
                .Name(name)
                .Rarity(rarity)
                .Type(type)
                .CP(cp)
                .IV(iv).EV(ev)
                .Team(team)
                .Build();

            return pokemon;
        }

        
        public static Dictionary<PokeStats, int> GenerateStats() {
            Dictionary<PokeStats, int> stats = new Dictionary<PokeStats, int>();
            
            int defense = MessageUtil.getInt("Defense: ");
            int attack = MessageUtil.getInt("Attack: ");
            int sattack = MessageUtil.getInt("Special Attack: ");
            int sdefense = MessageUtil.getInt("Special Defense: ");
            int speed = MessageUtil.getInt("Speed: ");
            
            stats.Add(PokeStats.Attack, attack);
            stats.Add(PokeStats.Defense, defense);
            stats.Add(PokeStats.Speed, speed);
            stats.Add(PokeStats.SpecialAttack, sattack);
            stats.Add(PokeStats.SpecialDefense, sdefense);
            
            return stats;
        }

        public static void DisplayPoke(Pokemon.Pokemon pokemon) {
            MessageUtil.MsgSpacer();
            MessageUtil.Msg("HOKEMON: " + pokemon.GetName());
            MessageUtil.Msg("Rarity: " + pokemon.GetRarity());
            MessageUtil.Msg("Type: " + pokemon.GetType());
            MessageUtil.Msg("Team: " + pokemon.GetTeam());
            MessageUtil.Msg("CP: " + pokemon.GetCP());
            
            MessageUtil.MsgSpacer();
            Console.WriteLine("EVs");
            MessageUtil.MsgSpacer();
            
            DisplayStats(pokemon.GetEVRaw());
            
            
            MessageUtil.MsgSpacer();
            Console.WriteLine("IVs");
            MessageUtil.MsgSpacer();
            
            DisplayStats(pokemon.GetIVRaw());
            
            
        }

        public static void DisplayStats(Dictionary<PokeStats, int> stat) {
            
            MessageUtil.Msg("Defense: " + stat[PokeStats.Attack]);
            MessageUtil.Msg("Attack: " + stat[PokeStats.Defense]);
            MessageUtil.Msg("Speed: " + stat[PokeStats.Speed]);
            MessageUtil.Msg("Special Attack: " + stat[PokeStats.SpecialAttack]);
            MessageUtil.Msg("Special Defense: " + stat[PokeStats.SpecialDefense]);
        }
        
    }
}
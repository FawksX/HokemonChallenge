using System;
using System.Collections.Generic;
using System.ComponentModel;
using HokemonChallenge.Pokemon.Impl;
using HokemonChallenge.Util;

namespace HokemonChallenge {
    
    class Program {
        
        public static void Main(string[] args) {

            Pokemon.Pokemon pokemon = CreatePokemon();

            Console.WriteLine(pokemon.GetName());
            Console.WriteLine(pokemon.GetRarity());
            Console.WriteLine(pokemon.GetCP());

        }
        

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

            Pokemon.Pokemon pokemon = Pokemon.Pokemon.Builder()
                .Name(name)
                .Rarity(rarity)
                .Type(type)
                .CP(cp)
                .IV(iv).EV(ev)
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
        
    }
}
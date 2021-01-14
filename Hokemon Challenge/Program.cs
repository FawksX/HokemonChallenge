using System;
using System.Collections.Generic;
using Hokemon_Challenge.Pokemon.Impl;

namespace Hokemon_Challenge {
    
    class Program {
        
        public static void Main(string[] args) {

            Pokemon.Pokemon newPoke = Pokemon.Pokemon.builder
                .Name("Test")
                .Rarity(EPokemonRarity.Legend)
                .Type(EPokemonTypes.Bug)
                .CP(1)
                .PokeStats(new Dictionary<PokeStats, int>())
                .Build();
        }
        
    }
}
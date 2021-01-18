namespace HokemonChallenge.Pokemon.Impl {
    
    public interface IPokemon {

        void SetType(EPokemonTypes type);
        void SetIV(PokeStats stat, int amount);
        void SetEV(PokeStats stat, int amount);
        
        void SetName(string newName);
        void SetCP(int newCp);
        
        string GetName();
        int GetCP();
        
        EPokemonTypes GetType();
        int GetIV(PokeStats stat);
        int GetEV(PokeStats stat);

        EPokemonTeams GetTeam();
        void SetPokemonTeams(EPokemonTeams team);

    }
}
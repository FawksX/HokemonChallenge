namespace Hokemon_Challenge.Pokemon.Impl {
    
    public interface IPokemon {

        void setType(EPokemonTypes type);
        void setStat(PokeStats stat, int amount);
        
        void SetName(string newName);
        void SetCP(int newCp);
        
        string GetName();
        int GetCP();
        
        EPokemonTypes GetType();
        int GetStatAmount(PokeStats stat);

    }
}
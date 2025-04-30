static class Biblioteca{
    static public Dictionary<int, Disco> BibliotecaM {get;private set;} = new Dictionary<int, Disco>();

    static public void Inicializarbiblioteca(){

        Artista Badbunny = new Artista("Bad Bunny");
        Productor prodDisco1 = new Productor ("Tiny");
        Disco unveranosinti = new Disco(Badbunny,prodDisco1,"un verano sin ti", 23,0001);

        Artista Tiny = new Artista("muchos");
        Productor prodDisco2 = new Productor ("Tiny");
        Disco data = new Disco(Tiny,prodDisco2,"data", 20,0002);

        Artista DeiV = new Artista("DeiV");
        Productor prodDisco3 = new Productor("Omar");
        Disco losFlavorz = new Disco(DeiV,prodDisco3,"los flavorz", 7,0003);
    }
    static public void agregarABiblioteca(Disco disco){
        BibliotecaM.Add(disco.ID,disco);
    }
   static public Dictionary<int,Disco> DevolverDiccionario()
    {
        return BibliotecaM;
    }
    }
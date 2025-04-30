class Disco{
    public Artista artista {get; private set;}
    public Productor productor {get;private set;}
    public string nombre {get;private set;}
    public int cantCanciones {get;private set;}
    public int ID;

    public Disco(Artista artista, Productor productor, string nombre, int canciones, int ID){
        this.artista = artista;
        this.productor = productor;
        this.nombre = nombre;
        this.cantCanciones = canciones;
        this.ID = ID;
    }
}
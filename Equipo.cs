public class Equipo
{
    public string Nombre;
    public List<Jugador> Jugadores;
    public Entrenador Entrenador;
    public Escuela Escuela;
    public Rama Rama;
}

public enum Rama
{
    Varonil, Femenil, Mixta
}
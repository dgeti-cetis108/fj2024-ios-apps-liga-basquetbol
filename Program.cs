

namespace LigaBasquetbol;

public class Program
{
    public static Escuela Organizador { get; set; } = new();
    public static Torneo Torneo { get; set; } = new();
    public static List<Equipo> Equipos { get; set; } = new();
    public static void Main(string[] args)
    {
        // definir la escuela organizadora
        definirOrganizador();
        // definir el torneo y
        // asignar el organizador de torneo
        definirTorneo();
        // definir 6 equipos
        definirEquipos();
        // definir las escuelas para cada equipo
        // cada equipo corresponde a una escuela
        // por cada equipo debe haber un entrenador
        // por cada equipo debe haber al menos 5 jugadores
        // definir los partidos, uno con cada contrincante
        // definir el rol y asignar los partidos
    }

    private static void definirEquipos()
    {
        Equipos.Add(new Equipo
        {
            Nombre = "Jaguares del CETis108",
            Rama = Rama.Mixta,
            Entrenador = new Entrenador
            {
                Nombres = "Pinky",
                Apellidos = "y Cerebro",
                Edad = 41,
                TorneosParticipando = 12,
                TorneosGanados = 6
            },
            Escuela = Organizador,
            Jugadores = new List<Jugador>
            {
                new Jugador { Nombres="Renato", Apellidos="Baez", Número=1},
                new Jugador { Nombres="Ramy", Apellidos="Jabur", Número=2},
                new Jugador { Nombres="Michelle", Apellidos="Luque", Número=23},
                new Jugador { Nombres="Paulina", Apellidos="Guevara", Número=32},
                new Jugador { Nombres="Antonio", Apellidos="Rodriguez", Número=11}
            }
        });
    }

    private static void definirTorneo()
    {
        Torneo.Categoría = "15-17";
        Torneo.Edición = "Profe Medardo";
        Torneo.Inicio = new DateTime(2024, 02, 06);
        Torneo.Fin = new DateTime(2024, 06, 15);
        Torneo.Organizador = Organizador;
    }

    private static void definirOrganizador()
    {
        Organizador.Nombre = "CETis108";
        Organizador.Cct = "25DCT0108H";
        Organizador.Director = "Marisela Beltrán";
    }
}


// TODO: crear un segundo equipo con 5 jugadores

// TODO: crear 4 equipos mas sin jugadores

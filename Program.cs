﻿
namespace LigaBasquetbol;

public class Program
{
    public static Escuela Organizador { get; set; } = new();
    public static void Main(string[] args)
    {
        // definir la escuela organizadora
        definirOrganizador();
        // definir 5 escuelas mas
        // definir el torneo
        // asignar el organizador de torneo
        // definir 6 equipos
        // cada equipo corresponde a una escuela
        // por cada equipo debe haber un entrenador
        // por cada equipo debe haber al menos 5 jugadores
        // definir los partidos, uno con cada contrincante
        // definir el rol y asignar los partidos
    }

    private static void definirOrganizador()
    {
        Organizador.Nombre = "CETis108";
        Organizador.Cct = "25DCT0108H";
        Organizador.Director = "Marisela Beltrán";
    }
}



// Definir un nuevo torneo
var torneo1 = new Torneo();
torneo1.Categoría = "15-17";
torneo1.Edición = "Profe Medardo";
torneo1.Inicio = new DateTime(2024,02,06);
torneo1.Fin = new DateTime(2024,06,15);

// definir la escuela organizadora
var cetis108 = new Escuela
{
    Nombre = "CETis108",
    Cct = "25DCT0108H",
    Director = "Marisela Beltrán"
};

torneo1.Organizador = cetis108;
// inicializar la lista de equipos del torneo
torneo1.Equipos = new List<Equipo>();

// definir el entrenador del cetis
var entrenadorCetis = new Entrenador
{
    Nombres = "Pinky",
    Apellidos = "y Cerebro",
    Edad = 41,
    TorneosParticipando = 12,
    TorneosGanados = 6
};

// definir los jugadores del cetis
var jugadorCetis1 = new Jugador
{
    Nombres = "Renato",
    Apellidos = "Baez",
    Número = 8
};

var jugadorCetis2 = new Jugador
{
    Nombres = "Ramy",
    Apellidos = "Jabur",
    Número = 9
};

var jugadorCetis3 = new Jugador
{
    Nombres = "Antonio",
    Apellidos = "Rodriguez",
    Número = 19
};

var jugadorCetis4 = new Jugador
{
    Nombres = "Michelle",
    Apellidos = "Luque",
    Número = 23
};

var jugadorCetis5 = new Jugador
{
    Nombres = "Paulina",
    Apellidos = "Guevara",
    Número = 2
};

// definir un equipo, cetis108
var equipoCetis = new Equipo
{
    Nombre = "Jaguares del CETis108",
    Rama = Rama.Mixta,
    Entrenador = entrenadorCetis,
    Escuela = cetis108,
    Jugadores = new List<Jugador>()
};

equipoCetis.Jugadores.Add(jugadorCetis1);
equipoCetis.Jugadores.Add(jugadorCetis2);
equipoCetis.Jugadores.Add(jugadorCetis3);
equipoCetis.Jugadores.Add(jugadorCetis4);
equipoCetis.Jugadores.Add(jugadorCetis5);

// TODO: crear un segundo equipo con 5 jugadores

// TODO: crear 4 equipos mas sin jugadores
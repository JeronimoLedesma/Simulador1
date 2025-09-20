using UnityEngine;
using Proyecto26;

public class SimulationManager : MonoBehaviour
{
    Report report = new Report();

    public static int piezasDerribadas;
    public static int numeroDisparo = 0;
    public static float anguloXDeArma;
    public static float anguloYDeArma;
    public static float masaDeProyectil;
    public static float fuerzaDeDisparo;
    public static bool acierto = false;

    public static void createReport()
    {
        Report report = new Report();
        RestClient.Put("https://simulador-balistico-default-rtdb.firebaseio.com/" + numeroDisparo + ".json", report);
        piezasDerribadas = 0;
        acierto = false;
    }
}

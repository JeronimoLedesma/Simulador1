using UnityEngine;

public class SimulationManager : MonoBehaviour
{
    public static int piezasDerribadas;
    public static Vector3 velocidadRelativa;
    public static Vector3 impulso;
    public static float tiempoDeVuelo;

    public static void createReport()
    {
        Debug.Log("Piezas Derribadas: " +  piezasDerribadas);
        Debug.Log("Velocidad Relativa: " +  velocidadRelativa);
        Debug.Log("Impulso de Colision: " + impulso);
        Debug.Log("Tiempo de Vuelo: " + tiempoDeVuelo + " segundos");
        piezasDerribadas = 0;
        velocidadRelativa = Vector3.zero;
        impulso = Vector3.zero;
        tiempoDeVuelo = 0;
    }
}

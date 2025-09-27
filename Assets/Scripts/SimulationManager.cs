using UnityEngine;
using Proyecto26;
using UnityEngine.UI;
using TMPro;

public class SimulationManager : MonoBehaviour
{
    Report report = new Report();

    public TMP_InputField idSearch;

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
        ReportShow.instance.ShowReport(report);
        piezasDerribadas = 0;
        acierto = false;
    }

    private void retrieveReport()
    {
        RestClient.Get<Report>("https://simulador-balistico-default-rtdb.firebaseio.com/" + idSearch.text + ".json").Then(response =>
        {
            report = response;
            ReportShow.instance.ShowReport(report);
        });
    }

    public void getReport()
    {
        retrieveReport();
    }
}

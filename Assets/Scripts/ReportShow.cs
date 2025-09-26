using TMPro;
using UnityEngine;

public class ReportShow : MonoBehaviour
{
    public static ReportShow instance{  get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
    }

    [SerializeField] private TextMeshProUGUI id_text;
    [SerializeField] private TextMeshProUGUI derribadas_text;
    [SerializeField] private TextMeshProUGUI anguloX_text;
    [SerializeField] private TextMeshProUGUI anguloY_text;
    [SerializeField] private TextMeshProUGUI masa_text;
    [SerializeField] private TextMeshProUGUI fuerza_text;
    [SerializeField] private TextMeshProUGUI acierto_text;

    public void ShowReport(Report report)
    {
        id_text.text = report.Id.ToString();
        derribadas_text.text = report.piezasDerribadas.ToString();
        anguloX_text.text = report.anguloXDeArma.ToString();
        anguloY_text.text = report.anguloYDeArma.ToString();
        masa_text.text = report.masaDeProyectil.ToString();
        fuerza_text.text = report.fuerzaDeDisparo.ToString();
        acierto_text.text = report.acierto.ToString();
    }
}

using System;

[Serializable]
public class Report
{
    public int Id;
    public int piezasDerribadas;
    public float anguloXDeArma;
    public float anguloYDeArma;
    public float masaDeProyectil;
    public float fuerzaDeDisparo;
    public bool acierto;

    public Report()
    {
        Id = SimulationManager.numeroDisparo;
        piezasDerribadas = SimulationManager.piezasDerribadas;
        anguloXDeArma = SimulationManager.anguloXDeArma;
        anguloYDeArma = SimulationManager.anguloYDeArma;
        masaDeProyectil = SimulationManager.masaDeProyectil;
        fuerzaDeDisparo = SimulationManager.fuerzaDeDisparo;
        acierto = SimulationManager.acierto;
    }
}

using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float flighTime;

    private void Update()
    {
        flighTime += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        SimulationManager.tiempoDeVuelo = flighTime;
        if (collision.collider.CompareTag("Floor"))
        {
            SimulationManager.createReport();
            Destroy(gameObject);
            return;
        }
    }
}

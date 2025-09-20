using UnityEngine;

public class CannonBall : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Cubes>() != null)
        {
            SimulationManager.acierto = true;
        }
        if (collision.collider.CompareTag("Floor"))
        {
            SimulationManager.createReport();
            Cannon.canShoot = true;
            Destroy(gameObject);
            return;
        }
    }
}

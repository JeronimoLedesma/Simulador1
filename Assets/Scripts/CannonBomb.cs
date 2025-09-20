using System.Collections;
using UnityEngine;

public class CannonBomb : MonoBehaviour
{
    [SerializeField] float power;
    [SerializeField] float radius;
    [SerializeField] float upforce;

    private void OnCollisionEnter(Collision collision)
    {
        
        Vector3 explosionPosition = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                if (rb.GetComponent<Cubes>() != null)
                {
                    SimulationManager.acierto = true;
                }
                rb.AddExplosionForce(power, explosionPosition, radius, upforce, ForceMode.Impulse);
            }
        }
        StartCoroutine(report_and_Die());
    }

    IEnumerator report_and_Die()
    {
        yield return new WaitForSeconds(3);
        SimulationManager.createReport();
        Cannon.canShoot = true;
        Destroy(gameObject);
    }
}

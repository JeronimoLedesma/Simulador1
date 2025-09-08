using System.Collections;
using UnityEngine;

public class CannonBomb : MonoBehaviour
{
    [SerializeField] float power;
    [SerializeField] float radius;
    [SerializeField] float upforce;
    public float flighTime;

    private void Update()
    {
        flighTime += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        SimulationManager.tiempoDeVuelo = flighTime;
        Vector3 explosionPosition = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPosition, radius, upforce, ForceMode.Impulse);
            }
        }
        StartCoroutine(report_and_Die());
    }

    IEnumerator report_and_Die()
    {
        yield return new WaitForSeconds(1);
        SimulationManager.createReport();
        Destroy(gameObject);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject[] cannonBallPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Slider fireForce;
    [SerializeField] private Slider angleXSlider;
    [SerializeField] private Slider angleYSlider;
    [SerializeField] private Slider projectileMass;
    private int selectedAmmo = 0;
    public static bool canShoot = true;

    public void Shoot()
    {
        if (!canShoot)
        {
            return;
        }

        if (cannonBallPrefab[selectedAmmo] != null & firePoint != null)
        {
            GameObject cannonBall = Instantiate(cannonBallPrefab[selectedAmmo], firePoint.position, firePoint.rotation);
            Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.mass = projectileMass.value;
                rb.AddForce(firePoint.up * fireForce.value);
                SimulationManager.numeroDisparo++;
                SimulationManager.anguloXDeArma = angleXSlider.value;
                SimulationManager.anguloYDeArma = angleYSlider.value;
                SimulationManager.fuerzaDeDisparo = fireForce.value;
                SimulationManager.masaDeProyectil = rb.mass;
                canShoot = false;
            }
        }
        else
        {
            Debug.LogWarning("No Cannon Ball Selected");
        }
    }

    public void CannonAngle()
    {
        float angleX = angleXSlider.value;
        float angleY = angleYSlider.value;
        transform.localRotation = Quaternion.Euler(angleX, angleY, 0);
    }

    public void changeAmmo(int selection)
    {
        selectedAmmo = selection;
    }
}

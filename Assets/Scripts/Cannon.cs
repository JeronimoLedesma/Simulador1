using UnityEngine;
using UnityEngine.UI;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject cannonBallPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireForce;
    [SerializeField] private Slider angleXSlider;
    [SerializeField] private Slider angleYSlider;

    public void Shoot()
    {
        if (cannonBallPrefab != null & firePoint != null)
        {
            GameObject cannonBall = Instantiate(cannonBallPrefab, firePoint.position, firePoint.rotation);
            Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(firePoint.up * fireForce);
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
}

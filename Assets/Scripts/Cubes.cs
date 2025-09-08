using UnityEngine;

public class Cubes : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ammo"))
        {
            Vector3 relativeVelocity = collision.relativeVelocity;
            SimulationManager.velocidadRelativa = relativeVelocity;
            Vector3 collisionImpulse = collision.impulse;
            SimulationManager.impulso = collisionImpulse;
        }
    }

    private void OnJointBreak(float breakForce)
    {
        SimulationManager.piezasDerribadas++;
    }
}

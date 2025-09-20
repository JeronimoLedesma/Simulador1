using UnityEngine;

public class Cubes : MonoBehaviour
{
    private void OnJointBreak(float breakForce)
    {
        SimulationManager.piezasDerribadas++;
    }
}

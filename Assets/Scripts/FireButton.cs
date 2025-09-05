using UnityEngine;

public class FireButton : MonoBehaviour
{
    [SerializeField] GameObject Cannon;

    public void OnClick()
    {
        if (Cannon.GetComponent<Cannon>() != null)
        {
            Cannon.GetComponent<Cannon>().Shoot();
        }
    }
}

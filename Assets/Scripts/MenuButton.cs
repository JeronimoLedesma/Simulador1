using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] Animator anim;
    private bool isOpen = true;

    public void ToggleMenu()
    {
        isOpen = !isOpen;
        anim.SetBool("Open", isOpen);
    }
}

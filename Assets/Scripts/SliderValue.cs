using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    [SerializeField]private Slider represent;
    private TextMeshProUGUI self;

    private void Start()
    {
        self = GetComponent<TextMeshProUGUI>();
    }

    public void changeValue()
    {
        self.text = represent.value.ToString();
    }
}

using UnityEngine;

public class ColorReceiver : MonoBehaviour
{
    private Renderer myRenderer;

    private void Awake()
    {
        myRenderer = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        if (ColorChange.instance != null)
        {
            ColorChange.instance.colorChanged += SetNewColor;
            SetNewColor(ColorChange.instance.GetCurrentColor());
        }
    }

    private void OnDisable()
    {
        if (ColorChange.instance != null)
        {
            ColorChange.instance.colorChanged -= SetNewColor;
        }
    }

    private void SetNewColor(Color newColor)
    {
        if (myRenderer != null)
        {
            myRenderer.sharedMaterial.color = newColor;
        }
    }
}
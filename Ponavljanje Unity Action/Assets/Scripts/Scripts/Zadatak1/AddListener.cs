using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AddListener : MonoBehaviour
{
    [SerializeField] private Button colorChangeButton;



    private void Start()
    {
        if(colorChangeButton == null)
        {
            colorChangeButton = GameObject.Find("ColorChangeButton")?.GetComponent<Button>();
        }

        if (colorChangeButton != null)
        {
            colorChangeButton.onClick.AddListener(OnButtonClick);
        }
        else
        {
            Debug.LogError("Gumb 'ColorChangeButton' nije pronaðen u sceni!");
        }
        colorChangeButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        if (ColorChange.instance != null)
        {
            ColorChange.instance.ShowNextColor();
        }
        else
        {
            Debug.LogError("Instanca klase 'ColorChange' nije pronaðena! Provjerite je li skripta 'ColorChange' u sceni.");
        }
    }


    private void OnDisable()
    {
        if (colorChangeButton != null)
        {
            colorChangeButton.onClick.RemoveListener(OnButtonClick);
        }
    }
}

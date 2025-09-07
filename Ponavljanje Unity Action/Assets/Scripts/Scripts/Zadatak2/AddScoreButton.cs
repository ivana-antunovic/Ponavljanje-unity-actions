using UnityEngine;
using UnityEngine.UI;

public class AddScoreButton : MonoBehaviour
{
    [SerializeField] private Button addButton;

    private void Start()
    {
        if (addButton != null)
        {
            addButton.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.AddScore(1); 
        }
        else
        {
            Debug.LogError("GameManager.instance je null!");
        }
    }

    private void OnDisable()
    {
        if (addButton != null)
        {
            addButton.onClick.RemoveListener(OnButtonClick);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;


public class AddListener : MonoBehaviour
{
    [SerializeField] private Button nameChangeButton;

   

    private void Awake()
    {
        

        if (nameChangeButton == null)
        {
            nameChangeButton = GameObject.Find("NameChange")?.GetComponent<Button>();
        }

       
    }

    private void Start()
    {
       

        if (nameChangeButton != null)
        {
            nameChangeButton.onClick.AddListener(() =>{GameManager.instance.ShowNextName();});
        }

       
    }
}

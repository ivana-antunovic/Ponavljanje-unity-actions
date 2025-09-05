using UnityEngine;
using UnityEngine.UI;


public class GunFire : MonoBehaviour
{
    [SerializeField] private Button addAmmoButton;

    private void Start()
    {
        GameManager.instance.onShowNameData += UpdateUI;
    }

    private void OnEnable()
    {
        addAmmoButton.onClick.AddListener(() => { GameManager.instance.AddAmmo(5); });
    }

    private void OnDisable()
    {
        if (GameManager.instance != null)
        {

            GameManager.instance.onShowNameData -= UpdateUI;
        }
    
    }

    private void UpdateUI(string name, string description, float fireRate, int ammo)
    {
        Debug.Log($"Fire Rate: {fireRate}");
    }
}

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private List<NameData> allNames;
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private TMP_Text ammoText;


    [SerializeField] private GameObject spawnPoint;
    private GameObject currentObject;

    

    private int currentIndex = 0;

    public  UnityAction<string, string, float, int> onShowNameData;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;


        if (allNames.Count > 0)
        {
            ShowName();
        }
    }

    public void ShowNextName()
    {
        if (allNames.Count == 0) return;

        currentIndex++;
        if (currentIndex >= allNames.Count)
            currentIndex = 0;

        ShowName();
    }

    private void ShowName()
    {
        NameData data = allNames[currentIndex];

        descriptionText.text = $" Name: {data.name} \n Description:{data.description}";
        ammoText.text = $"Ammo: {data.ammo}";




        if (currentObject != null)
        {
            Destroy(currentObject);
        }

        if(data.namePrefab != null)
        {
            currentObject = Instantiate(data.namePrefab, transform.position, transform.rotation);

            onShowNameData?.Invoke(data.name, data.description, data.fireRate, data.ammo);
        }
        
    }

    public void AddAmmo(int amount)
    {
        amount = 5;
    }
}


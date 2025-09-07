using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorChange : MonoBehaviour
{
    public static ColorChange instance;

    [SerializeField] private List<ColorData> allColors;

    public UnityAction<Color> colorChanged;

    private int currentIndex = 0;

    // Deklaracija varijable na razini klase
    private ColorData currentColorData;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        if (allColors.Count > 0)
        {
            ShowColor();
        }
    }

    public void ShowNextColor()
    {
        if (allColors.Count == 0) return;

        currentIndex++;
        if (currentIndex >= allColors.Count)
            currentIndex = 0;

        ShowColor();
    }

    private void ShowColor()
    {
        // Varijabla se sada koristi, ali nije deklarirana ovdje
        currentColorData = allColors[currentIndex];
        colorChanged?.Invoke(currentColorData.color);
    }

    public Color GetCurrentColor()
    {
        return allColors.Count > 0 ? allColors[currentIndex].color : Color.green;
    }
}
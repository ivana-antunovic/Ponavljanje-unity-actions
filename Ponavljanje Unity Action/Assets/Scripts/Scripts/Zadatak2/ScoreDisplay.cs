using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    private void OnEnable()
    {
        if (GameManager.instance != null)
        {
           
            GameManager.instance.scoreChanged += UpdateScore;

            
            UpdateScore(GameManager.instance.GetScore());
        }
    }

    private void OnDisable()
    {
        if (GameManager.instance != null)
        {
            
            GameManager.instance.scoreChanged -= UpdateScore;
        }
    }

    
    private void UpdateScore(int newScore)
    {
        Debug.Log($"{name} prima novi score: {newScore}");
    }
}

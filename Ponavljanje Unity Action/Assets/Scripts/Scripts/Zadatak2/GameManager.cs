using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UnityAction<int> scoreChanged;

    [SerializeField] private int score;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreChanged?.Invoke(amount);
    }

    public int GetScore()
    {
        return score;
    }
}

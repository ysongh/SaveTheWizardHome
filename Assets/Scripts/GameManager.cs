using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int houseHeath = 5;
    private int score= 0;
    public Text scoreText;

    public void HomeDamage()
    {
        houseHeath--;

        if(houseHeath <= 0)
        {
            Debug.Log("GameOver");
        }
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
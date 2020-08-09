using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(2);
        }
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
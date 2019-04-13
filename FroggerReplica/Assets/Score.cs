using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public static int CurrentScore = 0;
	public Text scoreText;

    public static int CurrentLives = 3;
    public Text livesText;

    void Start ()
	{

        if (SceneManager.GetActiveScene().name == "Main")
        {
            scoreText.text = "Score: " + CurrentScore.ToString();

            livesText.text = "Lives: " + CurrentLives.ToString();

        }

        if (SceneManager.GetActiveScene().name == "GameOverScene")
        {
            scoreText.text = "Your final score is: " + CurrentScore.ToString();

        }


    }

    private void Update()
    {
        livesText.text = "Lives: " + CurrentLives.ToString();
    }

}

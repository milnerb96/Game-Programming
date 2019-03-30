using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int CurrentScore = 0;
	public Text scoreText;

    public static int CurrentLives = 3;
    public Text livesText;


	void Start ()
	{
		scoreText.text = "Score: " + CurrentScore.ToString();

        livesText.text = "Lives: " + CurrentLives.ToString();

        }

    private void Update()
    {
        livesText.text = "Lives: " + CurrentLives.ToString();

    }

}

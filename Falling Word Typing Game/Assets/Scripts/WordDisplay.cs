using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WordDisplay : MonoBehaviour {

    public Text text;
    public Text scoreDisplayText;
    public Text lifeDisplayText;
    public float fallSpeed = 1f;
    public static int numLives = 3;
    public static int userScore = 0;

    public void SetWord (string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
        userScore += 10;
    }

    public void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);

        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
            numLives--;
        }

        if (numLives == 0)
        {
            SceneManager.LoadScene("EndScene");
        }

        scoreDisplayText.text = "Score: " + userScore.ToString();
        lifeDisplayText.text = "Lives: " + numLives.ToString();

    }
}

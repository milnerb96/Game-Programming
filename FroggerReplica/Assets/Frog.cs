using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{

    public Rigidbody2D rb;
    public AudioSource crash;
    public GameObject explosion;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        //crash = GetComponent<AudioSource>();

        if (col.tag == "Car")
        {
            //Debug.Log("WE LOST!");
            crash.Play();

            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(expl, 1); // delete the explosion after 3 seconds

            Score.CurrentLives -= 1;

        }

        if (col.tag == "Car" && Score.CurrentLives == 0)
        {
            crash.Play();
            Score.CurrentScore = 0;
            Score.CurrentLives = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
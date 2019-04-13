using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{

    public Rigidbody2D rb;
    public AudioSource crash;
    public GameObject explosion;
    public GameObject myFrog;
    public static float scale;


    private void Start()
    {
        ScaleFrog();
    }

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

    public void ScaleFrog()
    {
        myFrog.transform.localScale = new Vector3(scale, scale, scale);
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
            SceneManager.LoadScene("GameOverScene");
            Score.CurrentLives = 3;
        }
    }
}
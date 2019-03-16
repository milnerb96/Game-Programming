using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour
{

    public GameObject explosion;
  

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Zombie")
        {
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;

            Destroy(gameObject);
            Destroy(expl, 3);

            SceneManager.LoadScene("EndScreen");
        }

    }
}

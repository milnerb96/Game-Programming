using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;
    [SerializeField]
    private float delayBeforeLoading = 3f;
    private float timeElapsed;

    private void Start()
    {
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }

        if (agent.remainingDistance > agent.stoppingDistance)
        {

            character.Move(agent.desiredVelocity, false, false);
        }

        else
        {
            character.Move(Vector3.zero, false, false);
           
        }

        if (!gameObject)
        {
            timeElapsed += Time.deltaTime;
            SceneManager.LoadScene("EndScreen");
        }

    }
}

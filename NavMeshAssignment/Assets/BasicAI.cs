using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;


public class BasicAI : MonoBehaviour
{

    public Transform target;
    public Transform myTransform;
    public ThirdPersonCharacter character;
    public NavMeshAgent agent;
    public Collision coli;
    int distance = 1;

    // Update is called once per frame
    void Update()
    {

        agent.SetDestination(target.position);
        character.Move(agent.desiredVelocity, false, false);

       
    }


}
using UnityEngine;
using UnityEngine.AI;    //使用UnityEngine.AI

public class AIZomies : MonoBehaviour
{
    public NavMeshAgent agent;    //宣告NavMeshAgent

    private Animator ani;

    public Transform[] tracks;    //目標物件

    public GameObject AI;

    private int i;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider")
        {
            AI.SetActive(true);
        }
    }

    private void Update()
    {
        if (agent.remainingDistance <= 0.5f)
        {
            i++;

            if (i == tracks.Length) i = 0;
        }

        agent.SetDestination(tracks[i].position);
    }
}

using UnityEngine;
using UnityEngine.AI;

public class MoveDestination : MonoBehaviour {

    public Transform goal;
    private NavMeshAgent agent;

    private Vector3 lastDestination;

    void Start () {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update () {
        if (lastDestination == goal.position) {
            return;
        }

        lastDestination = goal.position;
        agent.ResetPath();
        agent.SetDestination(goal.position);
    }
}

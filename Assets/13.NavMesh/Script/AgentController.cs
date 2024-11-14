using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentController : MonoBehaviour
{
    public Transform pointer; // ��ǥ ��ġ�� ����Ű�� Transform
    private NavMeshAgent agent;

    public bool isStop;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(pointer.position); // pointer�� ��ġ�� �̵�
        agent.isStopped = isStop;
    }

}

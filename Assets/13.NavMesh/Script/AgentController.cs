using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentController : MonoBehaviour
{
    public Transform pointer; // 목표 위치를 가리키는 Transform
    private NavMeshAgent agent;

    public bool isStop;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(pointer.position); // pointer의 위치로 이동
        agent.isStopped = isStop;
    }

}

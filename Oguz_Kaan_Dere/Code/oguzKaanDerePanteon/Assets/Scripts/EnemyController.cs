using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject finishLine;
    public NavMeshAgent enemyAi;
    Animator anim;

    private void Start()
    {
        finishLine = GameObject.FindGameObjectWithTag("FinishLine");
        enemyAi = transform.GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetInteger("Run", 0);
    }
    void Update()
    {
        enemyAi.SetDestination(finishLine.transform.position);
        anim.SetInteger("Run", 1);
    }
}

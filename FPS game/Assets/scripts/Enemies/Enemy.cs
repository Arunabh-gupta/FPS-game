using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    float LookRadius = 10f;
    [SerializeField]Transform target;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
           float distance = Vector3.Distance(target.position, transform.position);
           if(distance<=LookRadius){
                agent.SetDestination(target.position);
           }
    }
    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}

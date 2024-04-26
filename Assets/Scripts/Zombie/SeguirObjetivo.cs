using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SeguirObjetivo : MonoBehaviour
{

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        GameObject objetivoTag = GameObject.FindGameObjectWithTag("p1");
        Transform objetivo = objetivoTag.transform;
        agent.destination = objetivo.position;
        RotateTowardsMovementDirection();
    }

    void RotateTowardsMovementDirection()
    {
        Vector2 direction = (agent.destination - (Vector3)transform.position).normalized;
        if (direction != Vector2.zero)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}

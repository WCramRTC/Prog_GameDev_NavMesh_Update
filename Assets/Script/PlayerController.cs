using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    public Transform _goal;
    NavMeshAgent _nma;

    // Start is called before the first frame update
    void Start()
    {
        _nma = GetComponent<NavMeshAgent>();
        _nma.SetDestination(_goal.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, _goal.position) > 1f)
        {
            _nma.SetDestination(_goal.position);
        }
    }
}

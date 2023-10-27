using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class GenerateNavMesh : MonoBehaviour
{

    public NavMeshSurface _surface;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("Building...?");
            _surface.BuildNavMesh();

        }
    }
}

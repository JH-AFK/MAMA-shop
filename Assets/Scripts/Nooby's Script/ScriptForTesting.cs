using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForTesting : MonoBehaviour
{
    List<Transform> location;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Sort();
    }

    void Sort()
    {
        location.Sort(delegate(Transform a, Transform B)
        {
            return (Vector3.SqrMagnitude(player.position - a.position).CompareTo
            (Vector3.SqrMagnitude(player.position - B.position)));
        }
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

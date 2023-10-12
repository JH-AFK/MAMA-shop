using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRespawner : MonoBehaviour
{
    public GachaPanel gp;
    public GameObject opening;
    public List<GameObject> capsuleList;
    // Start is called before the first frame update
    void Start()
    {
        capsuleList = new List<GameObject>(gp.capsules);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (capsuleList.Contains(other.gameObject))
        {
            Debug.Log("HI");
            other.gameObject.transform.position = gp.initCapsulePos[capsuleList.IndexOf(other.gameObject)];
            opening.SetActive(true);
        }
    }
}

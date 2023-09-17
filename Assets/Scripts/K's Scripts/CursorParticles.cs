using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorParticles : MonoBehaviour
{
    private Vector2 mousePos;
    public float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePos, moveSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointClicker : MonoBehaviour
{
    Vector3 target;
    public float speed;

    private void Start()
    {
        target = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit;
            if (hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero))
            {
                target = hit.point;
                Debug.Log(target);
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, target,speed * Time.deltaTime);
    }    
}

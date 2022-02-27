using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMover : MonoBehaviour
{
    public int destroyDistance = 10;

    private Vector3 endPoint;
    public float speed = 2f;

    public float distance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v = transform.position;
        v.x += distance;
        v.y += distance;
        endPoint = v;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, endPoint) > 1f)
        {
            transform.Translate(endPoint * speed * Time.deltaTime);
        }
        else
        {
            Destroy(transform.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}

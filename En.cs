using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerdamage;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position,
            speed *Time.deltaTime);
        transform.LookAt(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

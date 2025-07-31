using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pipe : MonoBehaviour
{
    public float speed; 
    
    void Start()
    {
        
    }

    void Update()
    {
        Move(); 
    }

    private void Move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; 
    }
}

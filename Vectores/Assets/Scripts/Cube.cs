using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour{

    Vector3 velocity = new Vector3(0,0);
    Vector3 acceleration = new Vector3(0,0);

    void Start(){
        
    }

    void Update(){
        transform.position += velocity * Time.deltaTime;
        velocity += acceleration;
    }
}
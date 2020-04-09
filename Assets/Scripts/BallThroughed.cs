using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThroughed : MonoBehaviour
{
    void OnCollisionEnter(Collision other){
        other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }
}

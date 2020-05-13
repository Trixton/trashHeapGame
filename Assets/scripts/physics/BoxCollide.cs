using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollide : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        Debug.Log("entered boxy");
    }
}

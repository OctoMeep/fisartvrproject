using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject Destination;

    public GameObject Object;

    public void go(){
        Object.transform.position = Destination.transform.position;
    }
}

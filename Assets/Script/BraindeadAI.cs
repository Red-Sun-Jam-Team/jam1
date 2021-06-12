using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BraindeadAI : MonoBehaviour {
    public bool active=true;
    public Transform target;
    void Awake() {
        var l = GameObject.FindGameObjectsWithTag("player");
        if(l.Length==1) target = l[0].transform;
        else target = l[Random.Range(0,l.Length)].transform;
    }

    // Update is called once per frame
    void Update() {
        if(active)
        transform.position = Vector3.MoveTowards(transform.position,target.position,0.1f);
    }
}

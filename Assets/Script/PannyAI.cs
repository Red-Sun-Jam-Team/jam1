using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannyAI : MonoBehaviour {
    NavMeshAgent2D Navi;
    GameObject Pointer;
    bool follow;
    // Start is called before the first frame update
    void Start() {
        Navi=GetComponent<NavMeshAgent2D>();
        Pointer=GameObject.FindGameObjectWithTag("pointer");
#if DEBUG || UNITY_EDITOR
        if(Navi==null) Debug.LogError("PannyAI: NavMesh2D is unassigned");
        if(Pointer==null) Debug.LogError("PannyAI: No pointer found, cannot follow it.");
#endif
    }
    void OnTriggerEnter2D(Collider2D c) {
        follow=c.gameObject.tag=="pointer";
    }
    void OnTriggerExit2D(Collider2D c) {
        if(c.gameObject.tag=="pointer") follow=false;
    }
    // Update is called once per frame
    void Update() {
        if(follow) Navi.destination=Pointer.transform.position;
    }
}

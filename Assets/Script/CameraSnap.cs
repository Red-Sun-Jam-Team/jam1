using UnityEngine;

public class CameraSnap : MonoBehaviour {
    GameObject target;
    void Awake() {
        target=GameObject.FindGameObjectWithTag("pointer");
    }

    // Update is called once per frame
    void Update() {
        transform.position=new Vector3(target.transform.position.x,target.transform.position.y,-10);
    }
}

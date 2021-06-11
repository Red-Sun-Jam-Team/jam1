using UnityEngine;

//TODO: Finish spawn script
public class Spawn : MonoBehaviour {
    public GameObject SpawnTarget;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
    void DoSpawn(GameObject s, Vector2 v) {
        var inst = Instantiate(s);
        inst.GetComponent<RigidBody2D>().AddForce(v);
    }
    void DoSpawn(GameObject s) {
        var inst = Instantiate(s);
    }
}

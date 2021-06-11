using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float Speed=5;
    public Animator Anim;
    void Start() {
        if(Anim==null) { //default to the attached animator
        Anim=GetComponent<Animator>();
        if(Anim==null) print("No animator attached to player.");
        }
    }
    void Update() {
        Anim.SetBool("Walking",Input.GetAxisRaw("Horizontal")!=0||Input.GetAxisRaw("Horizontal")!=0);
        transform.Translate(Input.GetAxisRaw("Horizontal")*Time.deltaTime*Speed,
          Input.GetAxisRaw("Vertical")*Speed*Time.deltaTime,0);
    }
}

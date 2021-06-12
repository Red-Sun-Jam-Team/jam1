using UnityEngine;

public class PointerMovement : MonoBehaviour {
    public float Speed=5f;
    void Update() {
       transform.Translate(
          Input.GetAxisRaw("Horizontal")*Time.deltaTime*Speed,
          Input.GetAxisRaw("Vertical")*Speed*Time.deltaTime,
          0);
    }
}

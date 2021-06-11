using UnityEngine;

public class Damage : MonoBehaviour {
    public DamageType type;
    public uint amount;
    // Start is called before the first frame update
    void Start() {
        if(amount==0) amount=1;
    }
}

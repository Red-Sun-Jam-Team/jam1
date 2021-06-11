using UnityEngine;

public class Health : MonoBehaviour {
    public uint health=10;
    // Start is called before the first frame update
#if DEBUG || EDITOR
    void Start() {
        if(health==0) print("Health: Value 0 from start.");
    }
#endif

    void OnCollisionEnter2D(Collision2D c) {
        var d=c.gameObject.GetComponent<Damage>();
        if(d==null) return; //if it aint there don't do anything.
        switch(d.type) {
            case DamageType.Harm: health -= d.amount; break;
            case DamageType.Heal: health += d.amount; break;
            case DamageType.Set: health = d.amount; break;
            default: print("Health: Unknown Tag"); break;
        }
    }
}

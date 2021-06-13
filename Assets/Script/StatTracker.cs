using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatTracker : MonoBehaviour {
    [Tooltip("Amou,t of Mana")]
    public static int Mana;
    [Tooltip("Maximum Possible Mana.")]
    public static uint ManaCap=1000;
    public List<GameObject> Cats;
    public const uint CatCap=16;
}

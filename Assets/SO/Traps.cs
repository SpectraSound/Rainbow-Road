
using UnityEngine;

[CreateAssetMenu(fileName = "Trap", menuName = "Object/Trap", order = 2)]
public class Traps : ScriptableObject {

    public string name;
    public bool IsTouched;
    public Sprite TrapSprite;

    public enum type {
        Spike,
        Falling,
        PowerUp,
        InvisibleBlock,

    }

    public type TrapType;
}

using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "inventory/item/sword", order = 1)]
public class SwordSO : item {
    public int Attackpower = 0;
    public enum Rarity {
        poor,
        normal,
        rare,
        epic,
        legendary
    }

    public Rarity TypeRarity = Rarity.poor;

}

using UnityEngine;

public class HealthV2 : MonoBehaviour
{
    public int maxHp = 100;
    public int accumuDamage = 0;

    public void TakeDamage(int damage)
    {
        accumuDamage += damage;
        if(accumuDamage >= maxHp)
        {
            Destroy(gameObject);
        }
    }
}

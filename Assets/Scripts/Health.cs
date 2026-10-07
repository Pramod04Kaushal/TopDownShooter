using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


}

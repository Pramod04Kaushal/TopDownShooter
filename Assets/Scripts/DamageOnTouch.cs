using UnityEngine;

public class DamageOnTouch : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health = collision.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }
    }
}

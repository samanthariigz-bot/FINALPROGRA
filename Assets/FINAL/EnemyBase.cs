using UnityEngine;

[RequireComponent(typeof(Collider), typeof(Rigidbody))]
public class EnemyBase : MonoBehaviour, IDamageable
{
    public EnemyProfile profile;
    protected int currentHealth;
    protected float speed;

    protected virtual void Awake()
    {
        if (profile != null)
        {
            currentHealth = profile.maxHealth;
            speed = profile.speed;
        }
    }

    protected virtual void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0) Die();
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }

    public bool IsDead => currentHealth <= 0;
}
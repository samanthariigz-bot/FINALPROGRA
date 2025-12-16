using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 3f;
    public float changeDirectionTime = 2f;

    private Vector3 randomDirection;
    private float timer;

    void Start()
    {
        SetRandomDirection();
    }

    void Update()
    {
        transform.Translate(randomDirection * speed * Time.deltaTime, Space.World);

        timer += Time.deltaTime;
        if (timer >= changeDirectionTime)
        {
            timer = 0;
            SetRandomDirection();
        }
    }

    void SetRandomDirection()
    {
        randomDirection = Random.onUnitSphere;
        randomDirection.y = 0;
        randomDirection.Normalize();
    }
}







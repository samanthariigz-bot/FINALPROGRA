using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;               
    public float changeDirectionTime = 2f; 

    private Vector3 direction;            
    private float timer;

    void Start()
    {
        CambiarDireccion();
    }

    void Update()
    {
        
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        
        timer += Time.deltaTime;
        if (timer >= changeDirectionTime)
        {
            CambiarDireccion();
        }
    }

    void CambiarDireccion()
    {
      
        direction = new Vector3(
            Random.Range(-1f, 1f),
            0f,                        
            Random.Range(-1f, 1f)
        ).normalized;

        timer = 0;
    }
}
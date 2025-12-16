public class FastEnemy : EnemyBase
{
    protected override void Awake()
    {
        base.Awake();
        speed *= 1.6f;
    }
}
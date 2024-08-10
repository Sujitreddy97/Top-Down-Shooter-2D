using UnityEngine;

namespace TopDownShooter.Bullet
{
    public class BulletController : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;

        void Update()
        {
            this.transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}

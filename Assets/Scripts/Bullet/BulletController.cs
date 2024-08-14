using UnityEngine;

namespace TopDownShooter.Bullet
{
    public class BulletController : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;
        private BulletPool bulletPool;
        private Vector2 direction;

        public void Initialize(BulletPool _pool)
        {
            this.bulletPool = _pool;
        }

        void Update()
        {
            this.transform.Translate(Vector2.right * speed * Time.deltaTime);

            if (IsOffScreen())
            {
                bulletPool.ReturnBullet(this);
            }

        }

        public void ConfigureBullet(Transform _spawnTransform)
        {
            this.gameObject.SetActive(true);
            this.transform.position = _spawnTransform.position;
            this.transform.rotation = _spawnTransform.rotation;
            
        }

        public void SetDirection(Vector2 dir)
        {
            direction = dir.normalized;
        }


        private bool IsOffScreen()
        {
            Vector3 screenPoint = Camera.main.WorldToViewportPoint(transform.position);
            return screenPoint.y > 1 || screenPoint.y < 0 || screenPoint.x > 1 || screenPoint.x < 0;
        }
    }
}

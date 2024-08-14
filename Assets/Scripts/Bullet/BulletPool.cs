using UnityEngine;
using TopDownShooter.Utilities;

namespace TopDownShooter.Bullet
{
    public class BulletPool : GenericObjectPool<BulletController>
    {
        private BulletController bulletPrefab;

        public BulletPool(BulletController bulletPrefab)
        {
            this.bulletPrefab = bulletPrefab;
        }

        public BulletController GetBullet()
        {
            BulletController bullet = GetItem<BulletController>();
            bullet.Initialize(this);
            return bullet;
        }

        protected override BulletController CreateItem<T>()
        {
            BulletController bullet = GameObject.Instantiate(bulletPrefab);
            bullet.gameObject.SetActive(false);
            bullet.Initialize(this);
            return bullet;
        }

        public void ReturnBullet(BulletController bullet)
        {
            bullet.gameObject.SetActive(false);
            ReturnItem(bullet);
        }
    }
}

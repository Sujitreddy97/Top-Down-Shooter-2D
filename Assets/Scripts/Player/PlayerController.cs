using TopDownShooter.Bullet;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;
using static UnityEngine.RuleTile.TilingRuleOutput;

namespace TopDownShooter.Player
{
    public class PlayerController
    {
        private PlayerModel playerModel;
        private PlayerView playerView;
        private Rigidbody2D rigidbody;
        private BulletPool bulletPool;

        public PlayerController(PlayerModel _playerModel, PlayerView _playerView, BulletPool _bulletPool)
        {
            this.playerModel = _playerModel;
            this.playerModel.SetPlayerController(this);
            this.playerView = GameObject.Instantiate<PlayerView>(_playerView);
            rigidbody = playerView.GetComponent<Rigidbody2D>();
            this.playerView.SetPlayerController(this);
            this.bulletPool = _bulletPool;
        }

        public void Move(float horizontal, float vertical)
        {
            Vector3 position = playerView.transform.position;
            position.x += horizontal * playerModel.GetMovementSpeed() * Time.deltaTime;
            position.y += vertical * playerModel.GetMovementSpeed() * Time.deltaTime;
            playerView.transform.position = position;
        }

        public void RotateWeapon(UnityEngine.Transform _weaponTransform)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePosition - playerView.transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            angle += 90f;

            if (angle > 90 || angle < -90)
            {
                _weaponTransform.localScale = new Vector3(1, -1, 1);
                angle = angle > 0 ? angle - 180 : angle + 180;
            }
            else
            {
                _weaponTransform.localScale = Vector3.one;
            }

            _weaponTransform.rotation = Quaternion.Euler(0, 0, angle);
        }

        public void Shoot(UnityEngine.Transform _spawnTransform)
        {
            if (Input.GetMouseButtonDown(0))
            {
                BulletController bullet = bulletPool.GetBullet();
                bullet.ConfigureBullet(_spawnTransform);
            }
        }
    }
}

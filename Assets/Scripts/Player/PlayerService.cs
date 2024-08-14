using TopDownShooter.Bullet;
using UnityEngine;


namespace TopDownShooter.Player
{
    public class PlayerService : MonoBehaviour
    {
        [SerializeField] private PlayerScriptableObject playerScriptableObject;
        [SerializeField] private PlayerView playerView;
        [SerializeField] private BulletController bulletPrefab;
      
        private PlayerModel playerModel;
        private PlayerController playerController;

        private void Awake()
        {
            BulletPool bulletPool = new BulletPool(bulletPrefab);
            playerModel = new PlayerModel(playerScriptableObject);
            playerController = new PlayerController(playerModel, playerView, bulletPool);
        }
    }
}
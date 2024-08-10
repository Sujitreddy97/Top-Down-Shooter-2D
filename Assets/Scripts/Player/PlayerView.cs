using UnityEngine;

namespace TopDownShooter.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform shootPosition;

        private PlayerController playerController;

        private void Update()
        {
            PlayerMovement();
            PlayerShoot();
        }

        private void FixedUpdate()
        {
            PlayerRotation();
        }

        private void PlayerMovement()
        {
            Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            playerController.Move(movement);
        }

        private void PlayerRotation()
        {
            playerController.Rotate();
        }

        private void PlayerShoot()
        {
            playerController.Shoot();
        }

        public void SetPlayerController(PlayerController _playerController)
        {
            this.playerController = _playerController;
        }

        public Transform Shootposition()
        {
            return shootPosition;
        }
    }
}



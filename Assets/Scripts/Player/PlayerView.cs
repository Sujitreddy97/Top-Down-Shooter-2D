using UnityEngine;

namespace TopDownShooter.Player
{
    public class PlayerView : MonoBehaviour
    {
        private PlayerController playerController;
                
        private void Update()
        {
            PlayerMovement();
        }

        private void FixedUpdate()
        {

        }

        private void PlayerMovement()
        {
            Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            playerController.Move(movement);
        }

        private void PlayerRotation()
        {

        }

        public void SetPlayerController(PlayerController _playerController)
        {
            this.playerController = _playerController;
        }
    }
}



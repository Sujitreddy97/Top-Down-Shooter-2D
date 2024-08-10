using UnityEngine;

namespace TopDownShooter.Player
{
    public class PlayerView : MonoBehaviour
    {
        private PlayerController playerController;

        public void SetPlayerController(PlayerController _playerController)
        {
            this.playerController = _playerController;
        }
    }
}



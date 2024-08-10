
namespace TopDownShooter.Player
{
    public class PlayerModel
    {
        private float maxHealth;
        private float movementSpeed;
        private PlayerScriptableObject playerScriptableObject;
        private PlayerController playerController;

        public void SetPlayerController(PlayerController _playerController)
        {
            this.playerController = _playerController;
        }
    }
}

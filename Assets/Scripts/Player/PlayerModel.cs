
namespace TopDownShooter.Player
{
    public class PlayerModel
    {
        private float maxHealth;
        private float movementSpeed;
        private PlayerScriptableObject playerScriptableObject;
        private PlayerController playerController;

        public PlayerModel(PlayerScriptableObject _playerScriptableObject)
        {
            this.playerScriptableObject = _playerScriptableObject;
            this.movementSpeed = playerScriptableObject.movementSpeed;
        }

        public void SetPlayerController(PlayerController _playerController)
        {
            this.playerController = _playerController;
        }

        public float GetMovementSpeed()
        {
            return movementSpeed;
        }
    }
}

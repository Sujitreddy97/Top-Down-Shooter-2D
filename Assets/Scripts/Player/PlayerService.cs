using UnityEngine;

namespace TopDownShooter.Player
{
    public class PlayerService : MonoBehaviour
    {
        [SerializeField] private PlayerScriptableObject playerScriptableObject;
        [SerializeField] private PlayerView playerView;
        private PlayerModel playerModel;
        private PlayerController playerController;

        private void Awake()
        {
            playerModel = new PlayerModel(playerScriptableObject);
            playerController = new PlayerController(playerModel, playerView);
        }
    }
}
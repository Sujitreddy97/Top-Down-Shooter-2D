
using UnityEngine;

namespace TopDownShooter.Player
{
    public class PlayerController 
    {
        private PlayerModel playerModel;
        private PlayerView playerView;

        public PlayerController(PlayerModel _playerModel, PlayerView _playerView)
        {
            this.playerModel = _playerModel;
            _playerModel.SetPlayerController(this);
            this.playerView = GameObject.Instantiate<PlayerView>(_playerView);
        }
    }
}

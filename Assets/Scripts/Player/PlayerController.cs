using UnityEngine;

namespace TopDownShooter.Player
{
    public class PlayerController
    {
        private PlayerModel playerModel;
        private PlayerView playerView;
        private Rigidbody2D rigidbody;

        public PlayerController(PlayerModel _playerModel, PlayerView _playerView)
        {
            this.playerModel = _playerModel;
            this.playerModel.SetPlayerController(this);
            this.playerView = GameObject.Instantiate<PlayerView>(_playerView);
            rigidbody = playerView.GetComponent<Rigidbody2D>();
            this.playerView.SetPlayerController(this);
        }

        public void Move(Vector2 movement)
        {
            rigidbody.MovePosition(rigidbody.position + movement * playerModel.GetMovementSpeed() * Time.deltaTime);
        }

        public void Rotate()
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 lookDirection = mousePosition - rigidbody.position;
            float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
            rigidbody.rotation = angle - 90f;

        }
    }   
}

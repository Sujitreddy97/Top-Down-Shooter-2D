using UnityEngine;

namespace TopDownShooter.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform shootTransform;
        [SerializeField] private Animator animator;
        private PlayerController playerController;
        private float lastX, lastY;

        

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
           
            PlayerMovement(horizontal, vertical);
            PlayerAnimation(horizontal, vertical);
            PlayerShoot();
        }

        private void FixedUpdate()
        {
            //PlayerRotation();           
        }

        private void PlayerMovement(float horizontal, float vertical)
        {
            Vector2 movement = new Vector2(horizontal, vertical);
            playerController.Move(horizontal, vertical);
        }

        private void PlayerRotation()
        {
            playerController.Rotate();
        }

        private void PlayerShoot()
        {
            playerController.Shoot(shootTransform);
        }


        private void PlayerAnimation(float horizontal, float vertical)
        {
            if (horizontal == 0 && vertical == 0)
            {
                animator.SetFloat("LastDirX", lastX);
                animator.SetFloat("LastDirY", lastY);
                animator.SetBool("IsMoving", false);
            }
            else
            {
                lastX = horizontal;
                lastY = vertical;
                animator.SetBool("IsMoving", true);
                Debug.Log("Player is moving");
            }
        }

        public void SetPlayerController(PlayerController _playerController)
        {
            this.playerController = _playerController;
        }

        public Transform Shootposition()
        {
            return shootTransform;
        }
    }
}



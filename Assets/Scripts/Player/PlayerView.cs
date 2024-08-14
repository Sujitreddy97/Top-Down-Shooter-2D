using UnityEngine;

namespace TopDownShooter.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform weaponTransform;
        [SerializeField] private Transform shootTransform;
        [SerializeField] private Animator animator;
        private PlayerController playerController;
        private float lastX, lastY;
        private GameObject mainCamera;

        private void Start()
        {
            mainCamera = GameObject.Find("Main Camera");
            mainCamera.transform.SetParent(this.transform);
        }

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
            PlayerWeaponRotation();
        }

        private void LateUpdate()
        {
            mainCamera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10f);
        }

        private void PlayerMovement(float horizontal, float vertical)
        {
            playerController.Move(horizontal, vertical);
        }

        private void PlayerWeaponRotation()
        {
            playerController.RotateWeapon(weaponTransform);
        }

        private void PlayerShoot()
        {
            playerController.Shoot(shootTransform);
        }


        private void PlayerAnimation(float horizontal, float vertical)
        {
            bool isMoving = Mathf.Abs(horizontal) > 0.01f || Mathf.Abs(vertical) > 0.01f;

            animator.SetBool("IsMoving", isMoving);

            if (isMoving)
            {
                animator.SetFloat("Horizontal", horizontal);
                animator.SetFloat("Vertical", vertical);
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



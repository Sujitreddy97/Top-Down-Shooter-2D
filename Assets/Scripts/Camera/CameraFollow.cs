using UnityEngine;
using TopDownShooter.Player;
using Unity.VisualScripting;


public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, -10f);
    [SerializeField] private float smoothSpeed = 0.125f;

    private PlayerView player;
    private Vector3 desiredPosition;


    private void Start()
    {

    }
    private void LateUpdate()
    {
        if (player != null)
        { 
            desiredPosition = player.transform.position + offset;
            Debug.Log(desiredPosition);
        }       
    }

    public void InitializePlayer(PlayerView _player)
    {
        player = _player;
    }
}

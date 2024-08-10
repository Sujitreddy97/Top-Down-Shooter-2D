using UnityEngine;

namespace TopDownShooter.Player
{
    [CreateAssetMenu(fileName = "Player Scriptable Object", menuName = "Scriptable Objects", order = 1)]
    public class PlayerScriptableObject : ScriptableObject
    {
        public float health;
        public float movementSpeed;
    }
}

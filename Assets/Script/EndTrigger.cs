using UnityEngine;

namespace Assets.Script
{
    public class EndTrigger : MonoBehaviour
    {
        public PlayerMovement player;

        void OnTriggerEnter()
        {
            FindObjectOfType<GameManager>().CompleteLevel();
            player.enabled = false;
        }
    }
}

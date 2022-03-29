using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Script
{
    public class playerCollision : MonoBehaviour
    {
        public PlayerMovement movement;
        public ScoreCount score;
        float delay = 3f;

        void OnCollisionEnter(Collision obj)
        {
            if (obj.collider.tag == "Obstacle")
            {
                movement.enabled = false;
                score.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
                Invoke("Restart", delay);
            }
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

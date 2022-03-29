using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Script
{
    public class ScoreCount : MonoBehaviour
    {
        public Transform player;
        public Text text;
        public ScoreCount scoreCount;
        bool gameOver = false;
        float delay = 3f;

        void FixedUpdate()
        {
            int score = Convert.ToInt32(player.position.z);
            text.text = score.ToString();

            if (player.position.y < -0.5f)
            {
                scoreCount.enabled = false;
                gameOver = true;
            }

            if (gameOver)
            {
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

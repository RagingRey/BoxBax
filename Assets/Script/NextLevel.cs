using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Script
{
    public class NextLevel : MonoBehaviour
    {
        public Text text;

        void LoadNextLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            text.text = GameManager.lastScore.ToString();
        }
    }
}

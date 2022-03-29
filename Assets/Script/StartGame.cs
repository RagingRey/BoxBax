using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Script
{
    public class StartGame : MonoBehaviour
    {
        public void OnStartClick()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void OnQuitClick()
        {
            Application.Quit();
        }

    }
}

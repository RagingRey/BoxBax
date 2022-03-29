using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Script
{
    public class Credits : MonoBehaviour
    {
        public void Exit()
        {
            SceneManager.LoadScene(0);
        }
    }
}
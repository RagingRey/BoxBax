using System;
using UnityEngine;

namespace Assets.Script
{
    public class GameManager : MonoBehaviour
    {
        public GameObject completeLevelUI;
        public GameObject gameOverUI;
        public Transform score;
        public static int lastScore = 0;

        public void EndGame()
        {
            gameOverUI.SetActive(true);
        }

        public void CompleteLevel()
        {
            lastScore += Convert.ToInt32(score.position.z);
            completeLevelUI.SetActive(true);
        }
    }
}

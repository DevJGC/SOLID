using UnityEngine;
using UnityEngine.UI;

namespace SolidPrinciples.S
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager instance;
        public Text scoreText;
        private int score = 0;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void AddScore(int value)
        {
            score += value;
            scoreText.text = "Score: " + score;
        }
    }
}

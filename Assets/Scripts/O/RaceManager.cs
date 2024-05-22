using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SolidPrinciples.O
{
    public class RaceManager : MonoBehaviour
    {
        public AnimalBase[] animals;
        public Transform finishLine;
        public TextMeshProUGUI winnerText;

        void Update()
        {
            foreach (var animal in animals)
            {
                if (animal.transform.position.x >= finishLine.position.x)
                {
                    winnerText.text = animal.name + " wins!";
                    Time.timeScale = 0; // Pausa el juego
                    break;
                }
            }
        }
    }
}

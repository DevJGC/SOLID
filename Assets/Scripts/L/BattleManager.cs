using UnityEngine;
using UnityEngine.UI;

namespace SolidPrinciples.L
{
    public class BattleManager : MonoBehaviour
    {
        public CharacterBase[] characters;
        public Text selectedCharacterText;
        private int currentIndex = 0;

        void Start()
        {
            UpdateSelectedCharacterText();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                characters[currentIndex].Attack();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                SelectNextCharacter();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SelectPreviousCharacter();
            }
        }

        void SelectNextCharacter()
        {
            currentIndex = (currentIndex + 1) % characters.Length;
            UpdateSelectedCharacterText();
        }

        void SelectPreviousCharacter()
        {
            currentIndex = (currentIndex - 1 + characters.Length) % characters.Length;
            UpdateSelectedCharacterText();
        }

        void UpdateSelectedCharacterText()
        {
            selectedCharacterText.text = "Selected: " + characters[currentIndex].characterName;
        }
    }
}

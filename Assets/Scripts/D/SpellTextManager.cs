using UnityEngine;
using TMPro;

namespace SolidPrinciples.D
{
    public class SpellTextManager : MonoBehaviour
    {
        public TMP_Text spellText;

        private static SpellTextManager _instance;

        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(gameObject); // Opcional, si quieres que persista entre escenas
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public static void UpdateSpellText(string text)
        {
            if (_instance != null && _instance.spellText != null)
            {
                _instance.spellText.text = text;
            }
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SolidPrinciples.I
{
    public class HeroManager : MonoBehaviour
    {
        public HeroBase[] heroes;
        public TextMeshProUGUI selectedHeroText;
        private int currentIndex = 0;

        void Start()
        {
            UpdateSelectedHeroText();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UseHeroAbility();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                SelectNextHero();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SelectPreviousHero();
            }
        }

        void UseHeroAbility()
        {
            var hero = heroes[currentIndex];
            if (hero is IMovable movableHero)
            {
                movableHero.Move();
            }
            if (hero is IAttackable attackableHero)
            {
                attackableHero.Attack();
            }
            if (hero is IHealable healableHero)
            {
                healableHero.Heal();
            }
        }

        void SelectNextHero()
        {
            currentIndex = (currentIndex + 1) % heroes.Length;
            UpdateSelectedHeroText();
        }

        void SelectPreviousHero()
        {
            currentIndex = (currentIndex - 1 + heroes.Length) % heroes.Length;
            UpdateSelectedHeroText();
        }

        void UpdateSelectedHeroText()
        {
            selectedHeroText.text = "Seleccionado: " + heroes[currentIndex].heroName;
        }
    }
}

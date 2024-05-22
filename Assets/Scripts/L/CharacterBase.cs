using UnityEngine;
using TMPro;

namespace SolidPrinciples.L
{
    public abstract class CharacterBase : MonoBehaviour, IAttackable
    {
        public string characterName;
        public abstract void Attack();

        public TextMeshProUGUI textCanvas;
    }
}

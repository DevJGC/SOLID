using UnityEngine;

namespace SolidPrinciples.L
{
    public class Warrior : CharacterBase
    {
        public override void Attack()
        {
            Debug.Log(characterName + " swings a sword!");
            // Implementar l�gica de ataque del guerrero
        }
    }
}

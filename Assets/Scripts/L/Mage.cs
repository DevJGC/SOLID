using UnityEngine;

namespace SolidPrinciples.L
{
    public class Mage : CharacterBase
    {
        public override void Attack()
        {
            Debug.Log(characterName + " casts a spell!");
            // Implementar lógica de ataque del mago
        }
    }
}

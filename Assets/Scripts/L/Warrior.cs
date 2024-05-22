using UnityEngine;
using System.Collections;

namespace SolidPrinciples.L
{
    public class Warrior : CharacterBase
    {
        public override void Attack()
        {
            Debug.Log(characterName + " ¡blande una espada!");
            // Implementar lógica de ataque del guerrero
            textCanvas.text = characterName + " ¡blande una espada!";
            StartCoroutine(ClearText());
        }

        //corrutina borrar texto tras 2 segundos
        IEnumerator ClearText()
        {
            yield return new WaitForSeconds(2);
            textCanvas.text = "";
        }
    }
}

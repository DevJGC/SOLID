using UnityEngine;
using System.Collections;

namespace SolidPrinciples.L
{
    public class Mage : CharacterBase
    {
        public override void Attack()
        {
            Debug.Log(characterName + " ¡lanza un hechizo!");
            // Implementar lógica de ataque del mago
            textCanvas.text = characterName + " ¡lanza un hechizo!";
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

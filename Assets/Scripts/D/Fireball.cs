using UnityEngine;

namespace SolidPrinciples.D
{
    public class Fireball : MonoBehaviour, ISorcery
    {
        public void ReleaseSorcery()
        {
            SpellTextManager.UpdateSpellText("Casting Fireball!");
            // Implementar l�gica de lanzamiento de bola de fuego
        }
    }
}

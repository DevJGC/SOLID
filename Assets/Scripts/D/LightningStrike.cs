using UnityEngine;

namespace SolidPrinciples.D
{
    public class LightningStrike : MonoBehaviour, ISorcery
    {
        public void ReleaseSorcery()
        {
            SpellTextManager.UpdateSpellText("Casting Lightning Strike!");
            // Implementar l�gica de lanzamiento de rayo
        }
    }
}

using UnityEngine;

namespace SolidPrinciples.D
{
    public class IceBlast : MonoBehaviour, ISorcery
    {
        public void ReleaseSorcery()
        {
            SpellTextManager.UpdateSpellText("Casting Ice Blast!");
            // Implementar l�gica de lanzamiento de r�faga de hielo
        }
    }
}

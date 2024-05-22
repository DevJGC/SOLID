using UnityEngine;

namespace SolidPrinciples.D
{
    public class IceBlast : MonoBehaviour, ISorcery
    {
        public void ReleaseSorcery()
        {
            SpellTextManager.UpdateSpellText("Casting Ice Blast!");
            // Implementar lógica de lanzamiento de ráfaga de hielo
        }
    }
}

using UnityEngine;

namespace SolidPrinciples.D
{
    public class SpellCaster : MonoBehaviour
    {
        private ISorcery sorcery;

        void Start()
        {
            // Inicializar con un hechizo por defecto si no se ha asignado
            if (sorcery == null)
            {
                sorcery = GetComponent<ISorcery>();
            }
        }

        void Update()
        {
            CallSorcery();
        }

        public void SetSorcery(ISorcery newSorcery)
        {
            sorcery = newSorcery;
        }

        void CallSorcery()
        {
            if (Input.GetKeyDown(KeyCode.F) && sorcery != null)
            {
                sorcery.ReleaseSorcery();
            }
        }
    }
}

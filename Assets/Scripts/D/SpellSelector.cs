using UnityEngine;
using System.Collections.Generic;
using TMPro;

namespace SolidPrinciples.D
{
    public class SpellSelector : MonoBehaviour
    {
        public SpellCaster spellCaster;
        [SerializeField] private List<MonoBehaviour> spellComponents;
        private List<ISorcery> availableSpells;
        public TMP_Dropdown spellDropdown;

        void Start()
        {
            // Convertir MonoBehaviours a ISorcery
            availableSpells = new List<ISorcery>();
            foreach (var component in spellComponents)
            {
                if (component is ISorcery)
                {
                    availableSpells.Add(component as ISorcery);
                }
            }

            // Configurar el menú desplegable con los nombres de los hechizos
            spellDropdown.ClearOptions();
            List<string> spellNames = new List<string>();
            foreach (var spell in availableSpells)
            {
                spellNames.Add(spell.GetType().Name);
            }
            spellDropdown.AddOptions(spellNames);

            // Establecer el hechizo inicial si hay hechizos disponibles
            if (availableSpells.Count > 0)
            {
                spellCaster.SetSorcery(availableSpells[0]);
                spellDropdown.value = 0;
                spellDropdown.onValueChanged.AddListener(delegate { OnSpellSelected(spellDropdown.value); });
            }
            else
            {
                Debug.LogError("No spells available. Please assign spells in the Inspector.");
            }
        }

        public void OnSpellSelected(int index)
        {
            if (index >= 0 && index < availableSpells.Count)
            {
                spellCaster.SetSorcery(availableSpells[index]);
            }
        }
    }
}

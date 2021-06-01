//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RPG.Combat
{
    class CombatTarget : MonoBehaviour
    {
        MeshRenderer thisRenderer;
        void Start()
        {
            thisRenderer = GetComponent<MeshRenderer>();
        }
        Color RandomColor()
        {
            return new Color(Random.Range(0.0f, 1.0F), Random.Range(0.0f, 1.0F), Random.Range(0.0f, 1.0F)); 
        }
    

        private void Update()
        {
            Material currentMaterial = thisRenderer.material;
            Material newMaterial = new Material(currentMaterial);
            newMaterial.SetColor("_Color", RandomColor());
            thisRenderer.material = newMaterial;
        }
    }
}

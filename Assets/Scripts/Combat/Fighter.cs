﻿using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    class Fighter : MonoBehaviour
    {
        [SerializeField] float weaponRange = 2f;
        Transform target;

        private void Update ()
        {
            if (target == null) return;
            
            if ( !GetIsRange())
            {
                GetComponent<Mover>().MoveTo(target.position);
            } 
            else
            {
                GetComponent<Mover>().Stop();
            }
        }

        private bool GetIsRange()
        {
            return Vector3.Distance(transform.position, target.position) < weaponRange;
        }
        public void Attack(CombatTarget combatTarget)
        {
            target = combatTarget.transform;
        }
        public void Cancel()
        {
            target = null;
        }

    }
}

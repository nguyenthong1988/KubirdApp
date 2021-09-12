using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Kubird
{
    public class Health : MonoBehaviour
    {
        public int value;
        public int maxValue;

        public void Damage(int value)
        {
            this.value -= value;
        }
    }
}
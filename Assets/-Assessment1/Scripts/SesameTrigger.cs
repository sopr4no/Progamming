using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{
    public class SesameTrigger : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.name.Contains("Sesame"))
            {
                // Adds a score
                GameManager.score++;
                // Remove a score
                //GameManager.score--;
                Destroy(col.gameObject);
            }


            if (col.name.Contains("Chip"))
            {
                // Remove a score
                GameManager.score--;
            Destroy(col.gameObject);
            }


        }

    }
}
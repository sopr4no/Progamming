using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{

    public class ChipTrigger : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D col)
        {
            // If hitting "Chip"
                // Add score
            // If hitting "Sesame"
                // Remove score

            // Adds a score
            GameManager.score++;
            // Remove a score
            //GameManager.score--;
            Destroy(col.gameObject);
        }
    }
}

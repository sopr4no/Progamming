using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

namespace Assessment1
{
    public class GameManager : MonoBehaviour
    {
        public static int score = 0;

        public Text scoreText;
        
        // Update is called once per frame
        void Update()
        {
            scoreText.text = "Score: " + score;
        }
    }
}
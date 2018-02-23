using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// {} - Braces
// [] - Brackets
// () - Paraenthesis
namespace Asteroids
{
    public class Moving : MonoBehaviour
    {
        // Member Variables
        public float rotationSpeed = 360;
        public float movementSpeed = 10;
        void Rotation()
        {

            // Rotate Right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);

            }
            // Rotate Left 
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }
        }
        void Movement()
        {
            // Move Up 
            // If the player is pressing the UP arrow
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //Move the player up by movementSpeed
                //Vector3 position = transform.position;
                //position.y += movementSpeed * Time.deltaTime; 
                //transform.position = position;
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            }

            //Movement Down
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

            }
        }

        // Update is called once per frame
        void Update()
        {
            // Call Movement() Function
            Movement();
            // Call Rotate() Function
            Rotation();
        }
    }

}

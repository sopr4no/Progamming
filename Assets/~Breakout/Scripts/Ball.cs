﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Ball : MonoBehaviour
    {
        public float speed = 5f; // Speed that the ball travels 

        private Vector3 velocity; // Velocity of the ball (Direction X Speed)

      
        public void Fire(Vector3 direction)

        {
            // Calculate velocity
            velocity = direction * speed;
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            // Grab contact point of collision
            ContactPoint2D contact = collision.contacts[0];
            // Calculate the reflection point of the ball using velocity & contact normal
            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);
            // Calculate new velocity from reflection multiply by the same speed (velocity.magnitude)
            velocity = reflect.normalized * velocity.magnitude;


        }

        // Update is called once per frame
        void Update()
        {
            // Moves ball using velocity & deltaTime
            transform.position += velocity * Time.deltaTime;
        }

    }

}

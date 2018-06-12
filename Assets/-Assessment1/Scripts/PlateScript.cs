using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{
    public class PlateScript : MonoBehaviour
    {
        public float movementSpeed = 10.0f;
        private Rigidbody2D rigid2D;
        private Renderer[] renderers;

        // Use this for initialization
        void Start()
        {
            rigid2D = GetComponent<Rigidbody2D>();
            renderers = GetComponentsInChildren<Renderer>();
            HandlePosition();
        }

        void Update()
        {
            HandleBoundary();
        }

        // Update is called once per frame
        void HandlePosition()
        {
            rigid2D.velocity = Vector3.right * movementSpeed;
        }

        void HandleBoundary()
        {
            if (IsVisible() == false)
            {
                Destroy(gameObject);
            }
        }

        bool IsVisible()
        {
            foreach (var renderer in renderers)
            {
                if (renderer.isVisible)
                {
                    return true;
                }

            }
            return false;
        }

    }
}
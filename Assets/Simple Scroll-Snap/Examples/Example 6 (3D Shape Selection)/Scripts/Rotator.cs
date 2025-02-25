﻿using UnityEngine;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float rotationSpeed = 0;

        private void Update()
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        }
    }
}
using System;
using Core;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        private void Update()
        {
            if (InputManager.instance.GetKeyDown("jump"))
            {
                Debug.Log("jump");
            }
        }
    }
}
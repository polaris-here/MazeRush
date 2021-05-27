using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MazeRush
{
    public class MovePlayer : ScriptableObject, IPlayerCommand
    {
        private readonly float Speed = 5.0f;
        public void Execute(GameObject player)
        {
            var rigidBody = player.GetComponent<Rigidbody>();

            if (rigidBody != null)
            {
                rigidBody.AddForce(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized * this.Speed, ForceMode.Impulse);
            }
        }
    }
}

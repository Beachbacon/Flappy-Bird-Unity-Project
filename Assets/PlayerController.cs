using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private KeyCode up = KeyCode.W;
        [SerializeField] private KeyCode left = KeyCode.A;
        [SerializeField] private KeyCode down = KeyCode.S;
        [SerializeField] private KeyCode right = KeyCode.D;

        private TranslateMover translateMover;


        private void Awake()
        {
            translateMover = GetComponent<TranslateMover>();
        }

        private void Start()
        {
            var position = transform.position;
            Debug.Log("Ma position initiale est : " + position);
        }

        private void Update()
        {
            if (Input.GetKeyDown(up))
                translateMover.Move(Vector3.up);
            if (Input.GetKeyDown(left))
                translateMover.Move(Vector3.left);
            if (Input.GetKeyDown(down))
                translateMover.Move(Vector3.down);
            if (Input.GetKeyDown(right))
                translateMover.Move(Vector3.right);
        }
    }
}

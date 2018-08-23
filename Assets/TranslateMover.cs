using UnityEngine;
using System.Collections;

namespace Game
{
    public class TranslateMover : MonoBehaviour
    {
        [SerializeField] private float speed = 5;

        public void Move(Vector3 direction)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
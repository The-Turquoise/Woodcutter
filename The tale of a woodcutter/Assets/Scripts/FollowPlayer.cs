using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform playerTransform;

    private void LateUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}

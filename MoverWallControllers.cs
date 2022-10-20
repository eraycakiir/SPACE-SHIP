using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverWallControllers : WallController
{
    [SerializeField] Vector3 direction;
    [Range(0f, 1f)]
    [SerializeField] float factor;
    [SerializeField] float speed;
    Vector3 startPos;
    private const float FullCircle = Mathf.PI * 2f;
    private void Awake()
    {
       startPos = transform.position;
    }
    private void Update()
    {
        float cycle = Time.time / speed;
        float sinwave = Mathf.Sin(cycle * FullCircle);
        factor = Mathf.Abs(sinwave);
        Vector3 offset = direction * factor;
        transform.position = offset + startPos;
    }
} 

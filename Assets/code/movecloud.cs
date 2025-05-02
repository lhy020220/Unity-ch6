using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class cloud : MonoBehaviour
{
    public float moveSpeed = 2f;      // 이동 속도
    public float moveRange = 3f;      // 좌우 이동 범위 (중심 기준)

    private Vector3 startPos;         // 시작 위치
    private int direction = 1;        // 이동 방향 (1: 오른쪽, -1: 왼쪽)

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // 이동
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);

        // 이동 범위를 벗어나면 방향 반전
        if (Mathf.Abs(transform.position.x - startPos.x) >= moveRange)
        {
            direction *= -1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public Animator animator; // ���������� ���� ��������� Animator � ��������� �������� �������

    void Start()
    {
        // ������������� �������� �������� �� ������
        animator.enabled = false;
    }

    void OnMouseDown()
    {
        // ��� ����� �� ������, �������� �������� ��������
        animator.enabled = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public Animator chestAnimator; // ������ �� ��������� Animator �������

    private bool isOpen = false; // ���������� ��� ������������ ��������� �������

    void Start()
    {
        // ������������� �������� �� ������ ��� ������� �������
        chestAnimator.enabled = false;
    }

    void OnMouseUp()
    {
        // ��� ����� �� ������, ������ ��� ���������
        isOpen = !isOpen;

        // �������� ��������������� �������� � ����������� �� ���������
        chestAnimator.SetBool("isOpen", isOpen);
    }

}

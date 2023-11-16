using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public Animator animator; // Перетащите сюда компонент Animator с анимацией открытия сундука

    void Start()
    {
        // Останавливаем анимацию открытия на старте
        animator.enabled = false;
    }

    void OnMouseDown()
    {
        // При клике на сундук, включаем анимацию открытия
        animator.enabled = true;
    }

}

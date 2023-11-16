using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public Animator chestAnimator; // Ссылка на компонент Animator сундука

    private bool isOpen = false; // Переменная для отслеживания состояния сундука

    void Start()
    {
        // Останавливаем анимацию на старте для каждого сундука
        chestAnimator.enabled = false;
    }

    void OnMouseUp()
    {
        // При клике на сундук, меняем его состояние
        isOpen = !isOpen;

        // Включаем соответствующую анимацию в зависимости от состояния
        chestAnimator.SetBool("isOpen", isOpen);
    }

}

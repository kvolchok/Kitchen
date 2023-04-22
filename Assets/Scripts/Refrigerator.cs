using UnityEngine;

public class Refrigerator : MonoBehaviour
{
    private Animator _animator;
    public bool IsOpen { get; private set; }

    private void Awake()
    {
        // Получаем компонент аниматор
        _animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        // Меняем флаг на противоположное значение
        IsOpen = !IsOpen;

        // Передаем значение флага в аниматор
        // (в зависимости от него будет проиграна анимация открытия или закрытия двери холодильника)
        _animator.SetBool("isOpen", IsOpen);
    }
}
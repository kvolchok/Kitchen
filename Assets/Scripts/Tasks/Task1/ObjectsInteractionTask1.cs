using UnityEngine;

namespace Tasks.Task1
{
    public class ObjectsInteractionTask1 : MonoBehaviour
    {
        // TODO: Получите доступ к объекту со скриптом Refrigerator при помощи атрибута [SerializeField]
        [SerializeField]
        private Refrigerator _refrigerator;

        [SerializeField]
        private int _time;

        // TODO: При нажатии на кнопку 1 на клавиатуре вызывайте у него метод Interact
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _refrigerator.Interact();
            }
        }
    }
}

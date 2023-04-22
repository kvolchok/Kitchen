using UnityEngine;

namespace Tasks.Task5
{
    public class ObjectsInteractionTask5 : MonoBehaviour
    {
        [SerializeField]
        private Shelf _shelf;

        [SerializeField]
        private int _countItemsToFall = 3;

        private void Awake()
        {
            _shelf.ItemSpawned += OnItemSpawned;
        }

        private void OnDestroy()
        {
            _shelf.ItemSpawned -= OnItemSpawned;
        }

        private void OnItemSpawned()
        {
            // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
            // TODO: Логика должна работать для обоих полок сцены
            if (_shelf.ItemsCount > _countItemsToFall)
            {
                _shelf.Fall();
            }
        }
    }
}
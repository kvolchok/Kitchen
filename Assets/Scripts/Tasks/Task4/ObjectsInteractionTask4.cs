using UnityEngine;

namespace Tasks.Task4
{
    public class ObjectsInteractionTask4 : MonoBehaviour
    {
        // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs)
        [SerializeField]
        private Toaster _toaster;

        [SerializeField]
        private Transform _wafflRoot;

        [SerializeField]
        private GameObject _wafflePrefab;

        private void Awake()
        {
            _toaster.TimerIsUp += SpawnWaffle;
        }

        private void OnDestroy()
        {
            _toaster.TimerIsUp -= SpawnWaffle;
        }
        
        private void SpawnWaffle()
        {
            Instantiate(_wafflePrefab, _wafflRoot);
        }
    }
}
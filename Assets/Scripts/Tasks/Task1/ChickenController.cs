using UnityEngine;

namespace Tasks.Task1
{
    public class ChickenController : MonoBehaviour
    {
        [SerializeField]
        private Transform _chicken;

        [SerializeField]
        private Transform _table;

        [SerializeField]
        private Refrigerator _refrigerator;

        [SerializeField]
        private float _chickenMovementSpeed = 2f;
        
        [SerializeField]
        private Vector3 _chickenRotationSpeed;
        
        private bool _canMove;

        private void Update()
        {
            if (_refrigerator.IsOpen && Input.GetKeyDown(KeyCode.Alpha3))
            {
                _canMove = true;
            }

            if (_canMove)
            {
                MoveChicken();

                if (IsChickenOnTable())
                {
                    _canMove = false;
                }
            }
            
            if (IsChickenOnTable())
            {
                RotateChicken();
            }
        }

        private void MoveChicken()
        {
            var step = _chickenMovementSpeed * Time.deltaTime;
            var newPosition = Vector3.MoveTowards(_chicken.position, _table.position, step);
            _chicken.position = newPosition;
        }
        
        private void RotateChicken()
        {
            _chicken.Rotate(_chickenRotationSpeed * Time.deltaTime, Space.Self);
        }

        private bool IsChickenOnTable()
        {
            return _chicken.position == _table.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _distance = 3f;
    [SerializeField] private float _time = 2.067f;
    //[SerializeField] private Animation _anim; для того щоб визначити час анімації

    private bool _isInMovement = false;
    private float _currentDistance = 0f;

    private void Update()
    {

        //Debug.Log(_anim["MoveLeft"].length); для того щоб визначити час анімації
        float dir = Input.GetAxisRaw("Horizontal");

        if (_isInMovement == false && dir != 0)
        {
            _isInMovement = true;
            if (dir > 0)
            {
                _animator.SetTrigger("Right");
            }
            if (dir < 0)
            {
                _animator.SetTrigger("Left");
            }
        }

        if (_isInMovement)
        {
            Move(dir);
        }
    }

    private void Move(float dir)
    {
        if (_currentDistance <= 0)
        {
            _isInMovement = false;
            return;
        }
        float speed = _distance / _time;
        float tmpDist = Time.deltaTime * speed;
        _characterController.Move(Vector3.right * dir * tmpDist);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private float _jumpForce = 10f;
    [SerializeField]
    private float _speed = 5f;
    private bool _groundCheck = false;
    private int _counter = 0;
    private void FixedUpdate()
    {
        float move = Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime;
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            _animator.SetBool("Walking", false);
        }
            if (Input.GetAxisRaw("Horizontal") == 1)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            _animator.SetBool("Walking", true);
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            _animator.SetBool("Walking", true);
        }
        transform.Translate(move, 0, 0);
        
        if (_groundCheck || _counter == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _counter++;
                this.GetComponent<Rigidbody2D>().velocity = Vector2.up * _jumpForce;
                
                _groundCheck = false;
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            _groundCheck = true;
            _counter = 0;
            Debug.Log("ChamDat");
        }
    }
}

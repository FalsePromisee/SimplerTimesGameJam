using UnityEngine;

public class Movement : MonoBehaviour
{ 
    private Rigidbody2D _rb;
    
    private Vector2 _horizontalMovementInput;
    private float _horizontalMovement;
    private int _speed;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }
    
    private void Update()
    {
        _horizontalMovementInput = new Vector2(Input.GetAxis("Horizontal"), 0f);
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = new Vector2(_horizontalMovementInput.x, 0f) * (Time.fixedDeltaTime * _speed);
    }
}

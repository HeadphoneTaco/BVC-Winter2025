using System;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float speed;
    public TextMeshProUGUI countText;
    
    private Rigidbody _rb;
    private int _count;

    private float _movementX;
    private float _movementY;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _count = 0;
        _rb = GetComponent<Rigidbody>();
        
        SetCountText();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(_movementX, 0.0f, _movementY);
        _rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            SetCountText();
            other.gameObject.SetActive(false);
            _count = _count + 1;
        }
        
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        _movementX = movementVector.x;
        _movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + _count.ToString();
    }
    
}

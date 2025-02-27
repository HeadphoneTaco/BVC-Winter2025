using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector2 _inputVector;
    [SerializeField] private float _rotationSpeed = 100f;
    private Rigidbody _rigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
           _rigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            
        }

        _inputVector = new Vector2(x, y);
        
        transform.Rotate(Vector3.up, _inputVector.x * Time.deltaTime* _rotationSpeed);
        transform.Translate(0 , 0,_inputVector.y );
      
        

    }
}

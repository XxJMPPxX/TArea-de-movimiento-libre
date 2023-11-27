using UnityEngine;

public class Amogus : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    

    public float velocidadX;
    public float velocidadY;
    public int direccionX ; 
    public int direccionY; 

    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D) == true)
        {
            direccionX= 1;
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            direccionX = -1;
        }
        else
        {
            direccionX = 0;
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            direccionY = 1;
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            direccionY = -1;
        }
        else
        {
            direccionY = 0;
        }
      



        transform.position = new Vector2(transform.position.x + velocidadX *direccionX* Time.deltaTime, transform.position.y + velocidadY * direccionY * Time.deltaTime);
      


    }
        void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        
    }
}
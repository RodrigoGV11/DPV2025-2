using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public float horizontal;
    public float vertical;
    public float velocidad, velocidadOriginal;
    public float gravedad;
    public Vector3 direccion;
    public CharacterController cc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       cc = this.gameObject.GetComponent<CharacterController>();
       velocidadOriginal = velocidad;
        
    }

    // Update is called once per frame
    void Update()
    {
        direccion = Vector3.zero;
        direccion.y -= gravedad * Time.deltaTime;
        direccion.x = Input.GetAxisRaw("Horizontal") * velocidad;
        direccion.z = Input.GetAxisRaw("Vertical") * velocidad;


        //this.transform.position += direccion;
        cc.Move(direccion * Time.deltaTime);
    }

    public void setVelocity(float velocidad)
    {
        this.velocidad = velocidad;
    }

    public void resetVelocity()
    {
        this.velocidad = velocidadOriginal;
    }
}

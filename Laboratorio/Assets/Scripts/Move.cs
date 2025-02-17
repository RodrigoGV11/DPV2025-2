using UnityEngine;

public class Move : MonoBehaviour
{

    public float velocidad;
    public float movVertical, movHorizontal;
    public int contador;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movHorizontal, 0, movVertical);

        rb.AddForce(movimiento * velocidad);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Calabaza")
        {
            Destroy(other.gameObject);
            contador++;
            Debug.Log("Calabazas recogidas: " + contador);
        }
    }
}

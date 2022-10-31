using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Comportamiento del Jugador
public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    private Vector3 salto;
    [SerializeField]
    private float velocidad = 3f;
    [SerializeField]
    private float fuerzaSalto = 3f;    
    [SerializeField]
    private bool enTierra;
    [SerializeField]
    private bool tienePremio;
    [SerializeField]
    private int contador;

    public bool TienePremio { get => tienePremio; set => tienePremio = value; }
    public int Contador { get => contador; set => contador = value; }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        salto = new Vector3(0, 2f, 0);
        tienePremio = false;
    }

    void OnCollisionStay()
    {
        enTierra = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        enTierra = false;
    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, 0, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * velocidad * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftControl) && enTierra)
        {
            
            rb.AddForce(salto * fuerzaSalto, ForceMode.Impulse);
            
        }
        if ((contador >= 3))
        {
            GameOver.Show();
        }
    }
}

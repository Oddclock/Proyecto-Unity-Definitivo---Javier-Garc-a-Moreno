using UnityEngine;
using System.Collections;

public class moneda : MonoBehaviour
{

    private Rigidbody2D rb;
    GameObject txt_moneda;
    Control_Monedas cm;
    public int suma;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(Random.Range(1, 1), Random.Range(1, 1)));
        txt_moneda = GameObject.Find("Texto_moneda");
        cm = txt_moneda.GetComponent<Control_Monedas>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            cm.suma_moneda(suma);
            Destroy(gameObject);
        }
    }
}
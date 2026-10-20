using UnityEngine;

public class Sesion7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Orco
{
    string nombre;
    float fuerza, resistencia, destreza, vida;

    public Orco(string nombre, float fuerza, float resistencia, float destreza)
    {
        this.nombre = nombre;
        this.fuerza = fuerza;
        this.resistencia = resistencia;
        this.destreza = destreza;
        vida = 100 * resistencia * 5;
    }

    void Atacar()
    {

    }

    void Defenderse(float danyoEntrante)
    {
        float danyoMitigado = danyoEntrante - resistencia * 1.5f;

        if (vida <= danyoMitigado)
        {
            Debug.Log("Has recibido " + danyoMitigado + " puntos de daño.");
            Debug.Log("Has muerto.");
        }
        else
        {
            vida -= danyoMitigado;
            Debug.Log("Has recibido " + danyoMitigado + " puntos de daño.\nTe quedan " + vida + " puntos de vida.");
        }
    }

    private float CalcularDanyoBasico()
    {
        float danyoBase = fuerza * 2 + Random.Range(-2, 3) + 5;
        float probCrit = destreza / 20.0f;

        if (Random.Range(0, 100) >= probCrit) danyoBase *= 1.5f;

        return danyoBase;
    }
}

using UnityEngine;

public class Orco
{
    string _nombre;
    float _fuerza, _resistencia, _destreza, _vida;

    public Orco(string nombre, float fuerza, float resistencia, float destreza)
    {
        this._nombre = nombre;
        this._fuerza = fuerza;
        this._resistencia = resistencia;
        this._destreza = destreza;
        _vida = 100 * resistencia * 5;
    }

    protected void Atacar(Orco objetivo)
    {
        float danyo = CalcularDanyoBasico();
        objetivo.RecibirDanyo(danyo);
    }

    void Defenderse(float danyoEntrante)
    {
        float danyoMitigado = danyoEntrante - _resistencia * 1.5f;

        if (_vida <= danyoMitigado)
        {
            Debug.Log("Has recibido " + danyoMitigado + " puntos de daño.");
            Debug.Log("Has muerto.");
        }
        else
        {
            _vida -= danyoMitigado;
            Debug.Log("Has recibido " + danyoMitigado + " puntos de daño.\nTe quedan " + _vida + " puntos de vida.");
        }
    }

    public void RecibirDanyo(float danyo)
    {
        _vida -= danyo;
    }

    private float CalcularDanyoBasico()
    {
        float danyoBase = _fuerza * 2 + Random.Range(-2, 3) + 5;
        float probCrit = _destreza / 20.0f;

        if (Random.Range(0, 100) >= probCrit) danyoBase *= 1.5f;

        return danyoBase;
    }

    public virtual void Gritar()
    {
        Debug.Log($"¡¡Soy {_nombre}!!");
    }

    public string GetNombre()
    {
        return _nombre;
    }
}

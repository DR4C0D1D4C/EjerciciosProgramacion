using UnityEngine;

public class OrcoDeMoria : Orco
{
    private float _precision;
    public OrcoDeMoria(string nombre, float fuerza, float resistencia, float destreza, float precision) : base(nombre, fuerza, resistencia, destreza)
    {
        this._precision = precision;
    }

    public void Disparar(Orco objetivo)
    {
        objetivo.RecibirDanyo(4.0f);
    }

    public override void Gritar()
    {
        Debug.Log($"¡¡Soy {GetNombre()} y soy un orco de Moria!!");
    }
}

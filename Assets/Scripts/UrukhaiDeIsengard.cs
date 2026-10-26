using UnityEngine;

public class UrukhaiDeIsengard : Orco
{
    private float _ira;
    public UrukhaiDeIsengard(string nombre, float fuerza, float resistencia, float destreza, float ira) : base(nombre, fuerza, resistencia, destreza)
    {
        this._ira = ira;
    }

    public void AtaqueBerserker(Orco objetivo)
    {
        Atacar(objetivo);

        objetivo.RecibirDanyo(0.5f * _ira);
    }

    public override void Gritar()
    {
        Debug.Log($"¡¡Soy {GetNombre()} y soy un uruk hai de Isengard!!");
    }
}

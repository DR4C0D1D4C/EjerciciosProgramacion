using UnityEngine;

public class Sesion5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EjerciciosBucles();
    }

    void EjerciciosBucles()
    {
        //Ej1

        int n = 4;
        string cubo = "";

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                cubo += "+ ";
            }
            cubo += "\n";
        }

        Debug.Log(cubo);

        //Ej2

        int n_niveles = 5;
        string semipiramide = "";

        for (int i = 0; i <= n_niveles; i++)
        {
            for (int j = 0; j < i; j++)
            {
                semipiramide += "+";
            }
            semipiramide += "\n";
        }

        Debug.Log(semipiramide);

        //Ej3

        int n_multi = 10;
        string tabla = "";

        for (int i = 0; i <= n_multi; i++)
        {
            if (i == 0)
            {
                tabla += "\t";
                for (int j = 1; j <= n_multi; j++)
                {
                    tabla += j + "\t";
                }
            }
            else
            {
                for (int j = 0; j <= n_multi; j++)
                {
                    if (j == 0)
                    {
                        tabla += i + "\t";
                    }
                    else
                    {
                        tabla += j * i + "\t";
                    }
                }
            }
            tabla += "\n";
        }

        Debug.Log(tabla);
    }
}

using UnityEngine;

public class Sesion3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GeneracionPJ();
        EjercicioBucleWhile1();
        EjercicioBucleWhile2();
    }

    void GeneracionPJ()
    {
        int fue = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int con = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int des = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int apa = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int pod = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int sue = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int tam = (Random.Range(1, 7) + Random.Range(1, 7) + 6) * 5;
        int inte = (Random.Range(1, 7) + Random.Range(1, 7) + 6) * 5;
        int edu = (Random.Range(1, 7) + Random.Range(1, 7) + 6) * 5;
        int mov = 0;
        int edad = Random.Range(15, 91);

        if (edad >= 15 && edad <= 19)
        {
            fue -= 5;
            tam -= 5;
            edu -= 5;
            int suerte2 = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
            if (suerte2 > sue)
            {
                sue = suerte2;
            }
        }

        if (edad >= 20 && edad <= 39)
        {
            int und100 = Random.Range(1, 101);
            if (edu < und100)
            {
                edu += Random.Range(1, 11);
            }
        }

        if (des < tam && fue < tam)
        {
            mov = 7;
        }
        else if (des > tam || fue > tam)
        {
            mov = 8;
        }
        else if (des > tam && fue > tam)
        {
            mov = 9;
        }

        if (edad >= 40 && edad <= 49)
        {
            mov -= 1;
        }
        else if (edad >= 50 && edad <= 59)
        {
            mov -= 2;
        }
        else if (edad >= 60 && edad <= 69)
        {
            mov -= 3;
        }
        else if (edad >= 70 && edad <= 79)
        {
            mov -= 4;
        }
        else if (edad >= 80 && edad <= 90)
        {
            mov -= 5;
        }
    }

    void EjercicioBucleWhile1()
    {
        int n = Random.Range(1, 1001);
        int i = 1;

        while (i < n)
        {
            Debug.Log(i);
            i++;
        }
    }
    void EjercicioBucleWhile2()
    {
        int num1 = Random.Range(1, 51);
        int num2 = Random.Range(1, 51);
        int resultado = 0;
        int i = 0;

        while (i < num2)
        {
            resultado += num1;
            i++;
        }

        Debug.Log(num1 + " * " + num2 + " = " + resultado);
    }

}

using UnityEngine;

public class Sesion6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    bool EsPar(int n)
    {
        return n % 2 == 0;
    }

    int Factorial(int n)
    {
        if (n == 0 || n == 1) return 1;

        return n * Factorial(n - 1);
    }

    int BuscarMayor(int[] arrayNums)
    {
        int mayor = 0;

        for (int i = 0; i < arrayNums.Length; i++)
        {
            if (arrayNums[i] > mayor)
            {
                mayor = arrayNums[i];
            }
        }

        return mayor;
    }

    void Saludar(string nombre)
    {
        Debug.Log(nombre);
    }

    float ConvertirTemperatura(float celcius)
    {
        float fahrenheit = celcius * (9 / 5) + 32;

        return fahrenheit;
    }
}

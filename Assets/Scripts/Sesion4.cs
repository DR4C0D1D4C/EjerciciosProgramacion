using UnityEngine;

public class Sesion4 : MonoBehaviour
{
    void Start()
    {
        SimulacionTiradas();
    }

    void EjerciciosFor()
    {
        //1

        int n = 10;
        int sum = 0;
        int numeroSumar = 1;

        for (int i = 0; i < n; i++)
        {
            sum += numeroSumar;
            numeroSumar++;
        }
        Debug.Log("Ejercicio de FOR 1");
        Debug.Log(sum);

        //2

        int initial_time = 60;

        Debug.Log("Ejercicio de FOR 2");

        for (int i = initial_time; i > 0; i--)
        {
            Debug.Log(i);
        }

        Debug.Log("Explosion");

        //3

        int n_pares = 20;

        Debug.Log("Ejercicio de FOR 3");

        for (int i = 1; i <= n_pares; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    void SimulacionTiradas()
    {
        int nCaras = 6;
        int nDados = 3;
        int nTiradas = 100;
        int[] tiradas = new int[nDados * nCaras + 1];

        for (int i = 0; i < nTiradas; i++)
        {
            int sumaResultado = 0;

            for (int j = 0; j < nDados; j++)
            {
                sumaResultado += Random.Range(1, nCaras + 1);
            }
            tiradas[sumaResultado]++;
        }

        for (int i = nDados; i < tiradas.Length; i++)
        {
            Debug.Log("Ha salido " + i + " un total de " + tiradas[i] + " veces");
        }
    }
}

using UnityEngine;

public class Sesion1 : MonoBehaviour
{
    int num1 = 2423;
    int num2 = 3285402;
    float distanciaEnMillas;
    float velocidad = 4.5f;
    float tiempo = 400.0f;
    float segundos = 3473.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Iniciando el curso.");
        Debug.Log(20394 + 103931);
        Debug.Log(130 * 340);
        Debug.Log(10.5f / 4.0f);
        Debug.Log(num1 * num2);
        Debug.Log(num2 / num1);
        Debug.Log(num2 % num1);
        distanciaEnMillas = 2500.0f / 1609.0f;
        Debug.Log("2500m son " + distanciaEnMillas + " millas.");
        Debug.Log("Si voy a " + velocidad + " m/s y han pasado " + tiempo + " segundos, he avanzado " + CalcularDistancia(velocidad, tiempo) + " metros.");
        Debug.Log(segundos + " segundos son " + TransformarTiempo(segundos) + " minutos.");
    }

    float CalcularDistancia(float v, float t)
    {
        float distancia = 0f;
        distancia = v * t;
        return distancia;
    }

    string TransformarTiempo(float t)
    {
        string tiempoFormateado = "";
        tiempoFormateado = (t / 60).ToString("00") + ":" + (t % 60).ToString("00");
        return tiempoFormateado;
    }
}

using UnityEngine;

public class Sesion2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Polinomio();
        CalcularEdad();
        Condicional();
        DetectarFueraDeMapa();
        DiaSemana();
        DetectarCuadrante();
        PiedraPapelTijera();
        AtaqueAUnidad();
    }

    void Polinomio()
    {
        float x = 5f;
        float resultado = 10f * Mathf.Pow(x, 3f) + 5f * Mathf.Pow(x, 2f) + 10f * x + 15f;
        Debug.Log(resultado);
    }

    void CalcularEdad()
    {
        int anyoNac = 2005;
        int anyoActual = System.DateTime.UtcNow.Year;
        int edad = anyoActual - anyoNac;
        Debug.Log(edad);
    }

    void Condicional()
    {
        int edad = 20;
        if (edad >= 18)
        {
            Debug.Log("Puedes acceder");
        }
        else
        {
            Debug.Log("No puedes acceder");
        }
        Debug.Log("++Fin del programa++");
    }

    void DetectarFueraDeMapa()
    {
        int flappyPosY = Random.Range(-30, 751);
        int limiteSuperiorY = 700;
        int limiteInferiorY = 0;
        if (flappyPosY < limiteInferiorY || flappyPosY > limiteSuperiorY)
        {
            Debug.Log("Te has salido del mapa, altura: " + flappyPosY);
        }
    }

    void DiaSemana()
    {
        int dia = Random.Range(1, 7);
        if (dia == 1)
        {
            Debug.Log("Lunes");
        }
        else if (dia == 2)
        {
            Debug.Log("Martes");
        }
        else if (dia == 3)
        {

            Debug.Log("Miércoles");
        }
        else if (dia == 4)
        {
            Debug.Log("Jueves");
        }
        else if (dia == 5)
        {
            Debug.Log("Viernes");
        }
        else if (dia == 6)
        {
            Debug.Log("Sábado");
        }
        else
        {
            Debug.Log("Domingo");
        }
    }

    void DetectarCuadrante()
    {
        int posX = Random.Range(-100, 101);
        int posY = Random.Range(-100, 101);
        Debug.Log("Coordenada x: " + posX + "\n Coordenada y: " + posY);
        if (posX > 0)
        {
            if (posY > 0)
            {
                Debug.Log("Estas en el cuadrante 1 (x e y positivos)");
            }
            else if (posY < 0)
            {
                Debug.Log("Estas en el cuadrante 2 (x positivo, y negativo)");
            }
            else
            {
                Debug.Log("Estas entre los cuadrantes 1 y 2");
            }
        }
        else if (posX < 0)
        {
            if (posY > 0)
            {
                Debug.Log("Estas en el cuadrante 3 (x negativo,  y positivo)");
            }
            else if (posY < 0)
            {
                Debug.Log("Estas en el cuadrante 4 (x e y negativos)");
            }
            else
            {
                Debug.Log("Estas entre los cuadrantes 3 y 4");
            }
        }
        else
        {
            if (posY > 0)
            {
                Debug.Log("Estas entre los cuadrantes 4 y 1");
            }
            else if (posY < 0)
            {
                Debug.Log("Estas entre los cuadrantes 3 y 2");
            }
            else
            {
                Debug.Log("Estas en el centro");
            }
        }
    }

    void PiedraPapelTijera()
    {
        // Piedra = 1, Papel = 2, Tijera = 3
        int jugador1 = Random.Range(1, 4);
        int jugador2 = Random.Range(1, 4);

        if (jugador1 == 1)
        {
            switch (jugador2)
            {
                case 1:
                    Debug.Log("Jugador 1: Piedra, Jugador 2: Piedra, EMPATE");
                    break;
                case 2:
                    Debug.Log("Jugador 1: Piedra, Jugador 2: Papel, GANA JUGADOR 2");
                    break;
                case 3:
                    Debug.Log("Jugador 1: Piedra, Jugador 2: Tijera, GANA JUGADOR 1");
                    break;
            }
        }
        else if (jugador1 == 2)
        {
            switch (jugador2)
            {
                case 1:
                    Debug.Log("Jugador 1: Papel, Jugador 2: Piedra, GANA JUGADOR 1");
                    break;
                case 2:
                    Debug.Log("Jugador 1: Papel, Jugador 2: Papel, EMPATE");
                    break;
                case 3:
                    Debug.Log("Jugador 1: Papel, Jugador 2: Tijera, GANA JUGADOR 2");
                    break;
            }
        }
        else
        {
            switch (jugador2)
            {
                case 1:
                    Debug.Log("Jugador 1: Tijera, Jugador 2: Piedra, GANA JUGADOR 2");
                    break;
                case 2:
                    Debug.Log("Jugador 1: Tijera, Jugador 2: Papel, GANA JUGADOR 1");
                    break;
                case 3:
                    Debug.Log("Jugador 1: Tijera, Jugador 2: Tijera, EMPATE");
                    break;
            }
        }
    }

    void AtaqueAUnidad()
    {
        int tiradaAtaque = Random.Range(1, 7);

        if (tiradaAtaque > 4)
        {
            Debug.Log("Ataque acierta");
            int tiradaDefensa = Random.Range(1, 7);
            if (tiradaDefensa < 5)
            {
                Debug.Log("Defensa falla");
                int herida = Random.Range(1, 7) + Random.Range(1, 7);
                Debug.Log("Daño de herida: " + herida);
                if (herida > 10)
                {
                    int tiradaMoral = Random.Range(1, 7);
                    if (tiradaMoral != 6)
                    {
                        Debug.Log("La unidad huye");
                    }
                    else
                    {
                        Debug.Log("La unidad supera la tirada de moral");
                    }
                }
            }
            else
            {
                Debug.Log("Defensa acierta");
            }
        }
        else
        {
            Debug.Log("Ataque falla");
        }
    }
}

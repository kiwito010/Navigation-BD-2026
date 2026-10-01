using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPTManager : MonoBehaviour
{

    public string[] jugadas = {"Roca", "Papel", "Tijera"};
    public int Puntos;
    public int PuntosRival;
    private string Resultado;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
        CheckResult("Roca");
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
        CheckResult("Papel");
        }

        else if (Input.GetKeyDown(KeyCode.T))
        {
        CheckResult("Tijera");
        }
    }


    void CheckResult(string jugada)
    {
        string jugadaContrincante = jugadas[Random.Range(0,3)];
        if (jugada == "Roca" && jugadaContrincante == "Papel" || jugada == "Papel" && jugadaContrincante == "Tijera" || jugada == "Tijera" && jugadaContrincante == "Roca"){
        Resultado = "Perdiste...";
        PuntosRival++;
        }

        else if (jugada == jugadaContrincante)
        {
            Resultado = "Empate";
       }
       else {
       Resultado = "¡Ganaste!";
       Puntos++;
       }
    Debug.Log("¡" + jugada + " VS " + jugadaContrincante + "! " + Resultado);
    }
}